import cv2
import mediapipe as mp
import numpy
import time
import math



# function definition to compute magnitude o f the vector
def magnitude(vector):
  return math.sqrt(sum(pow(element, 2) for element in vector))



def track_nose(nose_logic, shoulders_logic, nose_horizontal_sensibility, nose_vertical_sensibility, use_shoulders, shoulders_sensibility, calibration_time):

  mp_drawing = mp.solutions.drawing_utils
  mp_drawing_styles = mp.solutions.drawing_styles
  mp_pose = mp.solutions.pose


  ###############################
  # BUTTONS LOGIC
  ###############################


  # Init variables
  left_shoulder_last = 0
  right_shoulder_last = 0
  nose_base = 0
  pressTime = 0.1
  last_input_time = time.time()
  min_interval = 1
  message = False
  startTime = 0
  calibrated = False
  temp_left = 0
  temp_right = 0
  nose = 0
  delta_left = 0
  delta_right = 0
  delta_nose = 0


  ###############################
  ###############################
  ###############################

  cap = cv2.VideoCapture(0)
  with mp_pose.Pose(
      min_detection_confidence=0.5,
      min_tracking_confidence=0.5) as pose:
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
      results = pose.process(image)



      ###############################
      # CALIBRATION
      ###############################

      if results.pose_landmarks != None:
        temp_left = numpy.array([results.pose_landmarks.landmark[mp_pose.PoseLandmark.LEFT_SHOULDER].x, results.pose_landmarks.landmark[mp_pose.PoseLandmark.LEFT_SHOULDER].y])
        temp_right = numpy.array([results.pose_landmarks.landmark[mp_pose.PoseLandmark.RIGHT_SHOULDER].x, results.pose_landmarks.landmark[mp_pose.PoseLandmark.RIGHT_SHOULDER].y])
        nose = numpy.array([results.pose_landmarks.landmark[mp_pose.PoseLandmark.NOSE].x, results.pose_landmarks.landmark[mp_pose.PoseLandmark.NOSE].y])
        delta_left = numpy.linalg.norm(temp_left - left_shoulder_last)
        delta_right = numpy.linalg.norm(temp_right - right_shoulder_last)
        delta_nose = numpy.linalg.norm(nose - nose_base)

        if not calibrated:
          if not message:
            start_time = time.time()
            print("Calibrating... - Stay still wait " + str(calibration_time) + " seconds")
            message = True
          if time.time() - start_time > calibration_time:        
            left_shoulder_last = temp_left
            right_shoulder_last = temp_right
            nose_base = nose
            calibrated = True
            print("Calibration done. Now Tracking.")
        else:



          #################
          # NOSE #
          #################

          #### Get X and Y values ####
          x = (nose[0] - nose_base[0]) * nose_horizontal_sensibility
          if x > 1:
            x = 1
          elif x < -1:
            x = -1
          y = (nose[1] - nose_base[1]) * nose_vertical_sensibility
          if y > 1:
            y = 1
          elif y < -1:
            y = -1

          nose_logic(x, y)
          

          #################
          # SHOULDERS #
          #################
          if use_shoulders:
            trigger_left = delta_left > shoulders_sensibility
            trigger_right = delta_right > shoulders_sensibility
            
            shoulders_logic(trigger_left, trigger_right)
            


  ###############################
  ###############################
  ###############################

      # Draw the pose annotation on the image.
      image.flags.writeable = True
      image = cv2.cvtColor(image, cv2.COLOR_RGB2BGR)
      mp_drawing.draw_landmarks(
          image,
          results.pose_landmarks,
          mp_pose.POSE_CONNECTIONS,
          landmark_drawing_spec=mp_drawing_styles.get_default_pose_landmarks_style())
      # Flip the image horizontally for a selfie-view display.
      cv2.imshow('MediaPipe Pose', cv2.flip(image, 1))
      if cv2.waitKey(5) & 0xFF == 27:
        break
  cap.release()



def track_face(logic, options):

  mp_drawing = mp.solutions.drawing_utils
  mp_drawing_styles = mp.solutions.drawing_styles
  mp_face_mesh = mp.solutions.face_mesh



  ###############################
  # INITIALIZE VARIABLES
  ###############################

  # Base landmark positions
  nose_base = 0
  mouth_base = 0
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
  # pressTime = 0.1
  # last_input_time = time.time()
  # min_interval = 1
  nose_mouth_distance = 0
  message = False
  startTime = 0
  calibrated = False

  # Get options
  if "nose_horizontal_sensibility" in options:
    nose_horizontal_sensibility = options["nose_horizontal_sensibility"]
  if "nose_vertical_sensibility" in options:
    nose_vertical_sensibility = options["nose_vertical_sensibility"]
  if "mouth_horizontal_sensibility" in options:
    mouth_horizontal_sensibility = options["mouth_horizontal_sensibility"]
  if "mouth_vertical_sensibility" in options:
    mouth_vertical_sensibility = options["mouth_vertical_sensibility"]
  if "head_tilt_sensibility" in options:
    head_tilt_sensibility = options["head_tilt_sensibility"]  
  if "eyebrows_sensibility" in options:
    eyebrows_sensibility = options["eyebrows_sensibility"]
  if "mouth_open_sensibility" in options:
    mouth_open_sensibility = options["mouth_open_sensibility"]
  if "calibration_time" in options:
    calibration_time = options["calibration_time"]



  ###############################
  # TRACKING
  ###############################

  # For webcam input:
  drawing_spec = mp_drawing.DrawingSpec(thickness=1, circle_radius=1)
  cap = cv2.VideoCapture(0)
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
        nose = numpy.array([nose_point.x, nose_point.y, nose_point.z])
        
        # Mouth Centroid (as a numpy array)
        mouth_point_1, mouth_point_2, mouth_point_3 = facepoints[13], facepoints[181], facepoints[405]
        mouth_centroid_x = (mouth_point_1.x + mouth_point_2.x + mouth_point_3.x) / 3
        mouth_centroid_y = (mouth_point_1.y + mouth_point_2.y + mouth_point_3.y) / 3
        mouth_centroid_z = (mouth_point_1.z + mouth_point_2.z + mouth_point_3.z) / 3
        mouth = numpy.array([mouth_centroid_x, mouth_centroid_y, mouth_centroid_z])
        
        # Left Eye Centroid (as a numpy array)
        L_eye_point_1, L_eye_point_2, L_eye_point_3, L_eye_point_4  = facepoints[362], facepoints[386], facepoints[263], facepoints[374]
        L_eye_centroid_x = (L_eye_point_1.x + L_eye_point_2.x + L_eye_point_3.x + L_eye_point_4.x) / 4
        L_eye_centroid_y = (L_eye_point_1.y + L_eye_point_2.y + L_eye_point_3.y + L_eye_point_4.y) / 4
        L_eye_centroid_z = (L_eye_point_1.z + L_eye_point_2.z + L_eye_point_3.z + L_eye_point_4.z) / 4
        left_eye = numpy.array([L_eye_centroid_x, L_eye_centroid_y, L_eye_centroid_z])
        
        # Right Eye Centroid (as a numpy array)
        R_eye_point_1, R_eye_point_2, R_eye_point_3, R_eye_point_4  = facepoints[33], facepoints[159], facepoints[133], facepoints[145]
        R_eye_centroid_x = (R_eye_point_1.x + R_eye_point_2.x + R_eye_point_3.x + R_eye_point_4.x) / 4
        R_eye_centroid_y = (R_eye_point_1.y + R_eye_point_2.y + R_eye_point_3.y + R_eye_point_4.y) / 4
        R_eye_centroid_z = (R_eye_point_1.z + R_eye_point_2.z + R_eye_point_3.z + R_eye_point_4.z) / 4
        right_eye = numpy.array([R_eye_centroid_x, R_eye_centroid_y, R_eye_centroid_z])

        # Left left_eyebrow (as a magnitude value)
        left_eyebrow_point = facepoints[282]
        left_eyebrow = numpy.array([left_eyebrow_point.x, left_eyebrow_point.y, left_eyebrow_point.z])     
        eyebrows = magnitude(left_eyebrow - left_eye)
        
        # Open Mouth (as a magnitude value)
        mouth_upper_point, mouth_lower_point = facepoints[11], facepoints[16]
        mouth_upper, mouth_lower = numpy.array([mouth_upper_point.x, mouth_upper_point.y, mouth_upper_point.z]), numpy.array([mouth_lower_point.x, mouth_lower_point.y, mouth_lower_point.z])
        mouth_open = magnitude(mouth_upper - mouth_lower)

        # Head Tilt around Z axis (as a numpy array)
        head_tilt = L_eye_centroid_y - R_eye_centroid_y


        # Deltas
        # delta_nose = numpy.linalg.norm(nose - nose_base)
        # delta_mouth = numpy.linalg.norm(mouth - mouth_base)
        delta_eyebrows = (eyebrows - eyebrows_base) * eyebrows_sensibility
        delta_mouth_open = (mouth_open - mouth_open_base) * mouth_open_sensibility


        ###############################
        # CALIBRATION
        ###############################
        if not calibrated:
          if not message:
            start_time = time.time()
            print("Calibrating... - Stay still wait " + str(calibration_time) + " seconds")
            message = True
          if time.time() - start_time > calibration_time:
            nose_base = nose
            mouth_base = mouth
            nose_mouth_distance = magnitude(nose_base - mouth_base)
            head_tilt_base = head_tilt
            eyebrows_base = eyebrows
            mouth_open_base = mouth_open
            calibrated = True
            print("Calibration done. Now Tracking.")
        else:

          #################
          # LANDMARKS LOGIC #
          #################
          
          # NOSE
          nose_x = (nose[0] - nose_base[0]) * nose_horizontal_sensibility
          if nose_x > 1:
            nose_x = 1
          elif nose_x < -1:
            nose_x = -1
          nose_y = (nose[1] - nose_base[1]) * nose_vertical_sensibility
          if nose_y > 1:
            nose_y = 1
          elif nose_y < -1:
            nose_y = -1

          # MOUTH
          mouth_x = magnitude(numpy.array([nose[0], mouth[1], mouth[2]]) - mouth)
          if (nose[0] > mouth[0]):
            mouth_x *= -1
          mouth_y = magnitude(nose - numpy.array([nose[0], mouth[1], mouth[2]]))
          
          # HEAD TILT
          head_tilt_value = (head_tilt - head_tilt_base) * head_tilt_sensibility
          if head_tilt_value > 1:
            head_tilt_value = 1
          elif head_tilt_value < -1:
            head_tilt_value = -1
          # print(head_tilt_value)


          logic(
            nose_x,
            nose_y,
            mouth_x,
            mouth_y,
            head_tilt_value,
            delta_eyebrows > 1,
            delta_mouth_open > 1
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
      # Flip the image horizontally for a selfie-view display.
      cv2.imshow('MediaPipe Face Mesh', cv2.flip(image, 1))
      if cv2.waitKey(5) & 0xFF == 27:
        break
  cap.release()