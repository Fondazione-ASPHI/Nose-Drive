from eyeware.client import TrackerClient
import time
import numpy as np

# Init Eyeware Beam tracker client
tracker = TrackerClient()

# Init Gamepad controller
import vgamepad as vg # https://pypi.org/project/vgamepad/   https://github.com/ViGEm/ViGEmBus
gamepad = vg.VX360Gamepad()

# Get screen size
import pyautogui
screen_width, screen_height = pyautogui.size()


# MAIN LOOP
while True:
  if not tracker.connected:
    continue

  # EYES
  screen_gaze = tracker.get_screen_gaze_info()
  screen_gaze_is_lost = screen_gaze.is_lost
  halfscreen_x = screen_width / 2
  halfscreen_y = screen_height / 2
  gaze_x = (screen_gaze.x - halfscreen_x)/halfscreen_x
  gaze_y = (screen_gaze.y - halfscreen_y)/halfscreen_y

  # HEAD
  head_pose = tracker.get_head_pose_info()
  head_is_lost = head_pose.is_lost
  R = head_pose.transform.rotation
  pitch = np.arcsin(-R[1, 2])
  yaw = np.arctan2(R[0, 2], R[2, 2])
  roll = np.arctan2(R[1, 0], R[1, 1])
  pitch_deg = np.degrees(pitch) / 20 - 0.5
  yaw_deg = np.degrees(yaw)
  roll_deg = np.degrees(roll)

  # print (pitch_deg)
  

  # LOGIC
  if not screen_gaze_is_lost and not head_is_lost:

    gamepad.left_joystick_float(x_value_float=0, y_value_float=pitch_deg)
    gamepad.right_joystick_float(x_value_float=gaze_x, y_value_float=-gaze_y)


    gamepad.update()
    gamepad.reset()