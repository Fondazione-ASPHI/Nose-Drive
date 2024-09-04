import cv2
import mediapipe as mp
import numpy
import time
import math
import keyboard as kb
import platform
import sys


# function definition to compute magnitude o f the vector
def magnitude(vector):
  return math.sqrt(sum(pow(element, 2) for element in vector))


def get_keypress(keystring):
  if keystring != "" and keystring != None:
    return kb.is_pressed(keystring)


def track_face(logic, options):

  mp_drawing = mp.solutions.drawing_utils
  mp_drawing_styles = mp.solutions.drawing_styles
  mp_face_mesh = mp.solutions.face_mesh


  ###############################
  # INITIALIZE VARIABLES
  ###############################

  # Base landmark positions
  nose_base = 0
  mouth_x_base = 0
  head_tilt_base = 0
  eyebrows_base = 0
  mouth_open_base = 0

  # Updated landmark positions
  nose = 0
  mouth = 0
  head_tilt = 0
  eyebrows = 0
  mouth_open = 0

  # Deltas
  delta_nose = 0
  delta_mouth = 0
  delta_eyebrows = 0
  delta_mouth_open = 0

  # Sensibility values
  nose_horizontal_sensibility = 0
  nose_vertical_sensibility = 0
  mouth_horizontal_sensibility = 0
  mouth_vertical_sensibility = 0
  head_tilt_sensibility = 0
  eyebrows_sensibility = 0
  mouth_open_sensibility = 0
  calibration_time = 0

  # Misc variables
  nose_mouth_distance = 0
  message = False
  startTime = 0
  calibrated = False
  camera = 0
  paused = False
  pause_key_pressed = False
  reset_pos_key = "n"
  pause_key = "p"
  wait_time = 0
  font = cv2.FONT_HERSHEY_DUPLEX

  # Get options
  if "nose_horizontal_sensibility" in options:
    nose_horizontal_sensibility = options["nose_horizontal_sensibility"] * 10
  if "nose_vertical_sensibility" in options:
    nose_vertical_sensibility = options["nose_vertical_sensibility"] * 10
  if "mouth_horizontal_sensibility" in options:
    mouth_horizontal_sensibility = options["mouth_horizontal_sensibility"] * 15
  if "head_tilt_sensibility" in options:
    head_tilt_sensibility = options["head_tilt_sensibility"] * 10
  if "eyebrows_sensibility" in options:
    eyebrows_sensibility = options["eyebrows_sensibility"] * 40
  if "mouth_open_sensibility" in options:
    mouth_open_sensibility = options["mouth_open_sensibility"] * 50
  if "calibration_time" in options:
    calibration_time = options["calibration_time"]
  if "camera" in options:
    camera = options["camera"]
  if "reset_pos" in options:
    reset_pos_key = options["reset_pos"]
  if "pause" in options:
    pause_key = options["pause"]



  ###############################
  # TRACKING
  ###############################

  # For webcam input:
  drawing_spec = mp_drawing.DrawingSpec(thickness=1, circle_radius=1)
  
  cap = None
  if platform.system() == "Windows":
    cap = cv2.VideoCapture(camera, cv2.CAP_DSHOW)
  else:
    cap = cv2.VideoCapture(camera)

  with mp_face_mesh.FaceMesh(
      max_num_faces=1,
      refine_landmarks=True,
      min_detection_confidence=0.5,
      min_tracking_confidence=0.5) as face_mesh:
    while cap.isOpened():      
      success, image = cap.read()
      if not success:
        print("Ignoring empty camera frame.")
        # If loading a video, use 'break' instead of 'continue'.
        continue

      # To improve performance, optionally mark the image as not writeable to
      # pass by reference.
      image.flags.writeable = False
      image = cv2.cvtColor(image, cv2.COLOR_BGR2RGB)
      results = face_mesh.process(image)

      # Draw the face mesh annotations on the image.
      image.flags.writeable = True
      image = cv2.cvtColor(image, cv2.COLOR_RGB2BGR)
      if results.multi_face_landmarks:
        facepoints = results.multi_face_landmarks[0].landmark

        # Nose
        nose_point = facepoints[1]
        # nose = numpy.array([nose_point.x, nose_point.y, nose_point.z])
        
        # Head
        head_point = facepoints[8]

        # Pupils
        pupils_point = facepoints[474]

        # Mouth Centroid
        mouth_point = facepoints[13]
        mouth_point_x, mouth_point_y, mouth_point_z = mouth_point.x, mouth_point.y, mouth_point.z
        # mouth_point_1, mouth_point_2, mouth_point_3 = facepoints[13], facepoints[181], facepoints[405]
        # mouth_centroid_x = (mouth_point_1.x + mouth_point_2.x + mouth_point_3.x) / 3
        # mouth_centroid_y = (mouth_point_1.y + mouth_point_2.y + mouth_point_3.y) / 3
        # mouth_centroid_z = (mouth_point_1.z + mouth_point_2.z + mouth_point_3.z) / 3
        # mouth = numpy.array([mouth_centroid_x, mouth_centroid_y, mouth_centroid_z])
        mouth_x = magnitude(numpy.array([head_point.x, mouth_point_y, mouth_point_z]) - numpy.array([mouth_point_x, mouth_point_y, mouth_point_z]))
        if (head_point.x > mouth_point_x):
            mouth_x *= -1

        # Left Eye Centroid
        left_eye_point = facepoints[263]
        left_eye = numpy.array([left_eye_point.x, left_eye_point.y, left_eye_point.z])
        # L_eye_point_1, L_eye_point_2, L_eye_point_3, L_eye_point_4  = facepoints[362], facepoints[386], facepoints[263], facepoints[374]
        # L_eye_centroid_x = (L_eye_point_1.x + L_eye_point_2.x + L_eye_point_3.x + L_eye_point_4.x) / 4
        # L_eye_centroid_y = (L_eye_point_1.y + L_eye_point_2.y + L_eye_point_3.y + L_eye_point_4.y) / 4
        # L_eye_centroid_z = (L_eye_point_1.z + L_eye_point_2.z + L_eye_point_3.z + L_eye_point_4.z) / 4
        # left_eye = numpy.array([L_eye_centroid_x, L_eye_centroid_y, L_eye_centroid_z])
        
        # Right Eye Centroid
        right_eye_point = facepoints[33]
        right_eye = numpy.array([right_eye_point.x, right_eye_point.y, right_eye_point.z])
        # R_eye_point_1, R_eye_point_2, R_eye_point_3, R_eye_point_4  = facepoints[33], facepoints[159], facepoints[133], facepoints[145]
        # R_eye_centroid_x = (R_eye_point_1.x + R_eye_point_2.x + R_eye_point_3.x + R_eye_point_4.x) / 4
        # R_eye_centroid_y = (R_eye_point_1.y + R_eye_point_2.y + R_eye_point_3.y + R_eye_point_4.y) / 4
        # R_eye_centroid_z = (R_eye_point_1.z + R_eye_point_2.z + R_eye_point_3.z + R_eye_point_4.z) / 4
        # right_eye = numpy.array([R_eye_centroid_x, R_eye_centroid_y, R_eye_centroid_z])

        # Left left_eyebrow
        left_eyebrow_point = facepoints[282]
        left_eyebrow = numpy.array([left_eyebrow_point.x, left_eyebrow_point.y, left_eyebrow_point.z])     
        eyebrows = magnitude(left_eyebrow - left_eye)
        
        # Open Mouth
        mouth_upper_point, mouth_lower_point = facepoints[11], facepoints[16]
        mouth_upper, mouth_lower = numpy.array([mouth_upper_point.x, mouth_upper_point.y, mouth_upper_point.z]), numpy.array([mouth_lower_point.x, mouth_lower_point.y, mouth_lower_point.z])
        mouth_open = magnitude(mouth_upper - mouth_lower)

        # Head Tilt around Z axis
        head_tilt = left_eye_point.y - right_eye_point.y


        ###############################
        # CALIBRATION
        ###############################
        if not calibrated or get_keypress(reset_pos_key):
          if not message:
            start_time = time.time()
            print("Saving base position... - Stay still, wait " + str(calibration_time) + " seconds", file=sys.stderr)
            message = True
          wait_time = time.time() - start_time
          if wait_time > calibration_time:
            nose_base = nose_point
            mouth_x_base = mouth_x
            # nose_mouth_distance = magnitude(nose_base - mouth_base)
            head_tilt_base = head_tilt
            eyebrows_base = eyebrows
            mouth_open_base = mouth_open
            calibrated = True
            print("Base position saved. Press 'N' to reset base position.", file=sys.stderr)
            print("Now Tracking.", file=sys.stderr)
        else:

          #################
          # LANDMARKS LOGIC #
          #################
          
          # NOSE
          nose_x = (nose_point.x - nose_base.x) * nose_horizontal_sensibility
          if nose_x > 1:
            nose_x = 1
          elif nose_x < -1:
            nose_x = -1
          nose_y = (nose_point.y - nose_base.y) * nose_vertical_sensibility
          if nose_y > 1:
            nose_y = 1
          elif nose_y < -1:
            nose_y = -1
          # print(nose_x, nose_y)


          # MOUTH  
          mouth_x = (mouth_x - mouth_x_base) * mouth_horizontal_sensibility
          if mouth_x > 1:
            mouth_x = 1
          elif mouth_x < -1:
            mouth_x = -1
          # print(mouth_x)


          # HEAD TILT
          head_tilt = (head_tilt - head_tilt_base) * head_tilt_sensibility
          if head_tilt > 1:
            head_tilt = 1
          elif head_tilt < -1:
            head_tilt = -1
          # print(head_tilt)

          # EYEBROWS
          eyebrows = (eyebrows - eyebrows_base) * eyebrows_sensibility
          
          # MOUTH OPEN
          mouth_open = (mouth_open - mouth_open_base) * mouth_open_sensibility


          if get_keypress(pause_key):
            if not pause_key_pressed:
              pause_key_pressed = True              
              paused = not paused
              print("Paused: " + str(paused), file=sys.stderr)
          elif pause_key_pressed:
            pause_key_pressed = False
              

          if not paused:
            logic(
              -nose_x,
              nose_y,
              mouth_x,
              head_tilt,
              eyebrows > 1,
              mouth_open > 1
              )


        #################
        # DRAWINGS #
        #################
        for face_landmarks in results.multi_face_landmarks:
          # print(face_landmarks)
          mp_drawing.draw_landmarks(
              image=image,
              landmark_list=face_landmarks,
              connections=mp_face_mesh.FACEMESH_TESSELATION,
              landmark_drawing_spec=None,
              connection_drawing_spec=mp_drawing_styles
              .get_default_face_mesh_tesselation_style())
          mp_drawing.draw_landmarks(
              image=image,
              landmark_list=face_landmarks,
              connections=mp_face_mesh.FACEMESH_CONTOURS,
              landmark_drawing_spec=None,
              connection_drawing_spec=mp_drawing_styles
              .get_default_face_mesh_contours_style())
          mp_drawing.draw_landmarks(
              image=image,
              landmark_list=face_landmarks,
              connections=mp_face_mesh.FACEMESH_IRISES,
              landmark_drawing_spec=None,
              connection_drawing_spec=mp_drawing_styles
              .get_default_face_mesh_iris_connections_style())
      
      # Flip and show the image horizontally for a selfie-view display.
      flipped_image = cv2.flip(image, 1)

      # TEXT MESSAGE
      if not calibrated:        
        cv2.rectangle(flipped_image, (30, 15), (630, 70), (0, 0, 0), -1)
        cv2.putText(flipped_image, "Stay still in your base position: " + str(calibration_time - wait_time)[0], (50, 50), font, 1, (255, 255, 255), 2, cv2.LINE_4)
      else:
        message = "Now Tracking"
        rect_len = 270
        if pause_key != "":
          message += " - " + pause_key + ": pause"
          rect_len += 180
        if reset_pos_key != "":
          message += " - " + reset_pos_key + ": reset position"
          rect_len += 180
        cv2.rectangle(flipped_image, (30, 25), (rect_len, 60), (0, 0, 0), -1)
        cv2.putText(flipped_image, message, (50, 50), font, 0.75, (255, 255, 255), 2, cv2.LINE_4)
      
      # Show Image
      cv2.imshow("Nose Drive Tracking", flipped_image)

      # EXIT
      if cv2.waitKey(5) & 0xFF == 27:
        break
      if cv2.getWindowProperty("Nose Drive Tracking", cv2.WND_PROP_VISIBLE) <1:
        break
  cap.release()