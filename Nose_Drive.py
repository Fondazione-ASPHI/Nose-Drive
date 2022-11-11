############################
# You can EDIT the following values
############################

nose_horizontal_sensibility = 15 # suggested values between 0 and 30
nose_vertical_sensibility = 30 # suggested values between 0 and 30

use_shoulders = True # set this to True or False whether you want to track the shoulders or not
shoulders_sensibility = 0.05 # suggested values between 0.02 and 0.07

calibration_time = 5 # in seconds



############################
# DON'T EDIT BELOW THIS LINE (unless you know what you are doing)
############################

import cv2
import mediapipe as mp
import sys
import numpy
import keyboard as board
from pynput.keyboard import Key, Controller
from pynput import keyboard
import time
import vgamepad as vg # https://pypi.org/project/vgamepad/   https://github.com/ViGEm/ViGEmBus


mp_drawing = mp.solutions.drawing_utils
mp_drawing_styles = mp.solutions.drawing_styles
mp_pose = mp.solutions.pose


###############################
# BUTTONS LOGIC
###############################
args = sys.argv
debug = False
if len(args) > 1:
  debug = args[1] == "debug"

controller = Controller()
gamepad = vg.VX360Gamepad()

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


def get_data():
  global temp_left, temp_right, temp_nose, delta_left, delta_right, delta_nose, left_shoulder_last, right_shoulder_last, nose_last
  temp_left = numpy.array([results.pose_landmarks.landmark[mp_pose.PoseLandmark.LEFT_SHOULDER].x, results.pose_landmarks.landmark[mp_pose.PoseLandmark.LEFT_SHOULDER].y])
  temp_right = numpy.array([results.pose_landmarks.landmark[mp_pose.PoseLandmark.RIGHT_SHOULDER].x, results.pose_landmarks.landmark[mp_pose.PoseLandmark.RIGHT_SHOULDER].y])
  temp_nose = numpy.array([results.pose_landmarks.landmark[mp_pose.PoseLandmark.NOSE].x, results.pose_landmarks.landmark[mp_pose.PoseLandmark.NOSE].y])

  delta_left = numpy.linalg.norm(temp_left - left_shoulder_last)
  delta_right = numpy.linalg.norm(temp_right - right_shoulder_last)
  delta_nose = numpy.linalg.norm(temp_nose - nose_last)

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
# BUTTONS LOGIC
###############################

    # print(results.pose_landmarks.landmark[mp_pose.PoseLandmark.NOSE].x)
    # pose_detected = mp_pose != None
    # shoulders_detected = False
    # if pose_detected:
    #   shoulders_detected = mp_pose.PoseLandmark.LEFT_SHOULDER != None and mp_pose.PoseLandmark.RIGHT_SHOULDER != None

    if results.pose_landmarks != None:
      get_data()

      if not calibrated:
        if not message:
          start_time = time.time()
          print("Calibrating... - Stay still wait " + str(calibration_time) + " seconds")
          message = True
        # if board.is_pressed('q'):
        if time.time() - start_time > calibration_time:        
          left_shoulder_last = temp_left
          right_shoulder_last = temp_right
          nose_last = temp_nose
          calibrated = True
          print("Calibration done. Now Tracking.")
      else:

        # if (board.is_pressed('c')):
        #   calibrated = False
        #   message = False
        
#################
# SHOULDERS #
#################
        if use_shoulders:
          if (delta_left > shoulders_sensibility):
            # controller.press(Key.left) # Keyboard LEFT ARROW
            gamepad.press_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_A)  # Xbox360 A Button
            if debug:
              print("LEFT: " + str(delta_left))
          else:
            # controller.release(Key.left) # Keyboard LEFT ARROW
            gamepad.release_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_A)  # Xbox360 A button

          if (delta_right > shoulders_sensibility):
            # controller.press(Key.right) # Keyboard RIGHT ARROW
            gamepad.press_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_B)  # Xbox360 B Button
            if debug:
              print("RIGHT: " + str(delta_right))
          else:
            # controller.release(Key.right) # Keyboard RIGHT ARROW
            gamepad.release_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_B)  # Xbox360 B button


#################
# NOSE #
#################
        #### ANALOG ####
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
        gamepad.left_joystick_float(x_value_float=-x, y_value_float=0)
        if y > 0:
          # controller.release(Key.down)
          gamepad.right_trigger_float(value_float=y)
        elif y < 0:
          # controller.press(Key.down)
          gamepad.left_trigger_float(value_float=1)
        gamepad.update()
        gamepad.reset()
        
        if debug:
          print(x, y)

        #### ARROWS ####
        # nose_arrows_sensibility = 0.015
        # if  (temp_nose[0] - nose_last[0] > nose_arrows_sensibility):
        #   controller.press(Key.left)
        #   # print("NOSE left")
        # else:
        #   controller.release(Key.left)

        # if (nose_last[0] - temp_nose[0] > nose_arrows_sensibility):
        #   controller.press(Key.right)
        #   # print("NOSE right")
        # else:
        #   controller.release(Key.right)

        # if  (nose_last[1] - temp_nose[1] > nose_arrows_sensibility):
        #   controller.press(Key.down)
        #   # print("NOSE down")
        # else:
        #   controller.release(Key.down)

        # if (temp_nose[1] - nose_last[1] > nose_arrows_sensibility):
        #   controller.press(Key.up)
        #   # print("NOSE up")
        # else:
        #   controller.release(Key.up)
        

      # print(temp_nose)

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