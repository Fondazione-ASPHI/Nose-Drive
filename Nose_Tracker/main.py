import cv2
import mediapipe as mp
import numpy
import time
import math



def missing_logic(x, y):
  pass

# function definition to compute magnitude o f the vector
def magnitude(vector):
  return math.sqrt(sum(pow(element, 2) for element in vector))

def get_xy_value(temp_landmark, landmark_last, horizontal_sensibility, vertical_sensibility):
  x = (temp_landmark[0] - landmark_last[0]) * horizontal_sensibility
  if x > 1:
    x = 1
  elif x < -1:
    x = -1
  y = (temp_landmark[1] - landmark_last[1]) * vertical_sensibility
  if y > 1:
    y = 1
  elif y < -1:
    y = -1
  
  return x, y




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
  nose_last = 0
  pressTime = 0.1
  last_input_time = time.time()
  min_interval = 1
  message = False
  startTime = 0
  calibrated = False
  temp_left = 0
  temp_right = 0
  temp_nose = 0
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
        temp_nose = numpy.array([results.pose_landmarks.landmark[mp_pose.PoseLandmark.NOSE].x, results.pose_landmarks.landmark[mp_pose.PoseLandmark.NOSE].y])
        delta_left = numpy.linalg.norm(temp_left - left_shoulder_last)
        delta_right = numpy.linalg.norm(temp_right - right_shoulder_last)
        delta_nose = numpy.linalg.norm(temp_nose - nose_last)

        if not calibrated:
          if not message:
            start_time = time.time()
            print("Calibrating... - Stay still wait " + str(calibration_time) + " seconds")
            message = True
          if time.time() - start_time > calibration_time:        
            left_shoulder_last = temp_left
            right_shoulder_last = temp_right
            nose_last = temp_nose
            calibrated = True
            print("Calibration done. Now Tracking.")
        else:



          #################
          # NOSE #
          #################

          #### Get X and Y values ####
          x = (temp_nose[0] - nose_last[0]) * nose_horizontal_sensibility
          if x > 1:
            x = 1
          elif x < -1:
            x = -1
          y = (temp_nose[1] - nose_last[1]) * nose_vertical_sensibility
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



def track_face(options):

  import cv2
  import mediapipe as mp
  mp_drawing = mp.solutions.drawing_utils
  mp_drawing_styles = mp.solutions.drawing_styles
  mp_face_mesh = mp.solutions.face_mesh


  ###############################
  # BUTTONS LOGIC
  ###############################

  # Init variables
  nose_last = 0
  mouth_last = 0
  eyebrows_last = 0
  pressTime = 0.1
  last_input_time = time.time()
  min_interval = 1
  message = False
  startTime = 0
  calibrated = False
  temp_nose = 0
  temp_mouth = 0
  nose_mouth_distance = 0
  temp_eyebrows = 0
  delta_nose = 0
  delta_mouth = 0
  delta_eyebrows = 0
  logic = None
  nose_horizontal_sensibility = 0
  nose_vertical_sensibility = 0
  mouth_horizontal_sensibility = 0
  mouth_vertical_sensibility = 0
  eyebrows_sensibility = 0
  calibration_time = 0


  # Get options
  logic = options["logic"]  
  if "nose horizontal sensibility" in options:
    nose_horizontal_sensibility = options["nose horizontal sensibility"]
  if "nose vertical sensibility" in options:
    nose_vertical_sensibility = options["nose vertical sensibility"]
  if "mouth horizontal sensibility" in options:
    mouth_horizontal_sensibility = options["mouth horizontal sensibility"]
  if "mouth vertical sensibility" in options:
    mouth_vertical_sensibility = options["mouth vertical sensibility"]
  if "eyebrows sensibility" in options:
    eyebrows_sensibility = options["eyebrows sensibility"]
  if "calibration time" in options:
    calibration_time = options["calibration time"]


  ###############################
  ###############################
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

        # Nose        
        temp_nose = numpy.array([results.multi_face_landmarks[0].landmark[1].x, results.multi_face_landmarks[0].landmark[1].y, results.multi_face_landmarks[0].landmark[1].z])
        
        # Mouth Centroid
        mouth_centroid_x = (results.multi_face_landmarks[0].landmark[13].x + results.multi_face_landmarks[0].landmark[181].x + results.multi_face_landmarks[0].landmark[405].x) / 3
        mouth_centroid_y = (results.multi_face_landmarks[0].landmark[13].y + results.multi_face_landmarks[0].landmark[181].y + results.multi_face_landmarks[0].landmark[405].y) / 3
        mouth_centroid_z = (results.multi_face_landmarks[0].landmark[13].z + results.multi_face_landmarks[0].landmark[181].z + results.multi_face_landmarks[0].landmark[405].z) / 3
        temp_mouth = numpy.array([mouth_centroid_x, mouth_centroid_y, mouth_centroid_z])
        
        # Left Eye Centroid
        eye_x = (results.multi_face_landmarks[0].landmark[362].x + results.multi_face_landmarks[0].landmark[386].x + results.multi_face_landmarks[0].landmark[263].x + results.multi_face_landmarks[0].landmark[374].x) / 4
        eye_y = (results.multi_face_landmarks[0].landmark[362].y + results.multi_face_landmarks[0].landmark[386].y + results.multi_face_landmarks[0].landmark[263].y + results.multi_face_landmarks[0].landmark[374].y) / 4
        eye_z = (results.multi_face_landmarks[0].landmark[362].z + results.multi_face_landmarks[0].landmark[386].z + results.multi_face_landmarks[0].landmark[263].z + results.multi_face_landmarks[0].landmark[374].z) / 4
        eye_centroid = numpy.array([eye_x, eye_y, eye_z])
        
        # Left Eyebrow
        eyebrow = numpy.array([results.multi_face_landmarks[0].landmark[282].x, results.multi_face_landmarks[0].landmark[282].y, results.multi_face_landmarks[0].landmark[282].z])     
        temp_eyebrows = magnitude(eyebrow - eye_centroid)
        
        # Deltas
        # delta_nose = numpy.linalg.norm(temp_nose - nose_last)
        # delta_mouth = numpy.linalg.norm(temp_mouth - mouth_last)
        delta_eyebrows = temp_eyebrows - eyebrows_last


        ###############################
        # CALIBRATION
        ###############################
        if not calibrated:
          if not message:
            start_time = time.time()
            print("Calibrating... - Stay still wait " + str(calibration_time) + " seconds")
            message = True
          if time.time() - start_time > calibration_time:
            nose_last = temp_nose
            mouth_last = temp_mouth
            nose_mouth_distance = magnitude(nose_last - mouth_last)
            eyebrows_last = temp_eyebrows
            calibrated = True
            print("Calibration done. Now Tracking.")
        else:

          #################
          # LANDMARKS LOGICS #
          #################
          nose_x, nose_y = get_xy_value(temp_nose, nose_last, nose_horizontal_sensibility, nose_vertical_sensibility)
          mouth_x, mouth_y = get_xy_value(temp_mouth, mouth_last, mouth_horizontal_sensibility, mouth_vertical_sensibility)
          
          logic(
            nose_x,
            nose_y,
            nose_x - mouth_x,
            nose_y - mouth_y,
            delta_eyebrows > eyebrows_sensibility
            )


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