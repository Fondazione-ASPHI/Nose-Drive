############################
# You can EDIT the following values
############################

nose_horizontal_sensibility = 10 # suggested values between 0 and 30
nose_vertical_sensibility = 30 # suggested values between 0 and 30

calibration_time = 5 # in seconds



############################
# DON'T EDIT BELOW THIS LINE (unless you know what you are doing)
############################

import cv2
import numpy
import time
import math

# Init Mediapipe
import mediapipe as mp
mp_drawing = mp.solutions.drawing_utils
mp_drawing_styles = mp.solutions.drawing_styles
mp_face_mesh = mp.solutions.face_mesh

# Init Gamepad controller
import vgamepad as vg # https://pypi.org/project/vgamepad/   https://github.com/ViGEm/ViGEmBus
gamepad = vg.VX360Gamepad()

def get_analog_xy(temp_landmark, landmark_last, horizontal_sensibility, vertical_sensibility):
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



###############################
# BUTTONS LOGIC
###############################

# Init variables
message = False
startTime = 0
calibrated = False
nose = 0
nose_base = 0

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
          calibrated = True
          print("Calibration done. Now Tracking.")
      else:

        #################
        # NOSE LOGIC #
        #################
        nose_x, nose_y = get_analog_xy(nose, nose_base, nose_horizontal_sensibility, nose_vertical_sensibility)
        gamepad.left_joystick_float(x_value_float=-nose_x, y_value_float=0)
        if nose_y > 0:
          # controller.release(Key.down)
          gamepad.right_trigger_float(value_float=nose_y)
        elif nose_y < 0:
          # controller.press(Key.down)
          gamepad.left_trigger_float(value_float=1) # value_float=-y if you want analog brake
        gamepad.update()
        gamepad.reset()



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