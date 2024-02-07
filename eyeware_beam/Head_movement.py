from eyeware.client import TrackerClient
import time
import numpy as np

# Build tracker client, to establish a communication with the tracker server (an Eyeware application).
#
# Constructing the tracker client object without arguments sets a default server hostname and port which
# work fine in many configurations.
# However, it is possible to set a specific hostname and port, depending on your setup and network.
# See the TrackerClient API reference for further information.
tracker = TrackerClient()

# Make sure that the connection with the tracker server (Eyeware application) is up and running.





# Init Gamepad controller
import vgamepad as vg # https://pypi.org/project/vgamepad/   https://github.com/ViGEm/ViGEmBus
gamepad = vg.VX360Gamepad()

import pyautogui
screen_width, screen_height = pyautogui.size()

#################
# NOSE #
#################
while True:
  if not tracker.connected:
    continue

  
  head_pose = tracker.get_head_pose_info()
  head_is_lost = head_pose.is_lost
  halfscreen_x = screen_width / 2
  halfscreen_y = screen_height / 2

  # print(head_pose.transform.rotation)
  # Assuming R is your 3x3 rotation matrix
  # R = np.array([[r11, r12, r13], [r21, r22, r23], [r31, r32, r33]])
  R = head_pose.transform.rotation

  # Calculate Pitch
  pitch = np.arcsin(-R[1, 2])

  # Calculate Yaw
  yaw = np.arctan2(R[0, 2], R[2, 2])

  # Calculate Roll (if needed)
  roll = np.arctan2(R[1, 0], R[1, 1])

  # Convert radians to degrees, if preferred
  pitch_deg = np.degrees(pitch)
  yaw_deg = np.degrees(yaw)
  roll_deg = np.degrees(roll)

  print(f"Pitch: {pitch_deg} degrees")
  print(f"Yaw: {yaw_deg} degrees")
  print(f"Roll: {roll_deg} degrees")


  gamepad.update()
  gamepad.reset()
  # print(gaze_x, gaze_y)
  # time.sleep(1 / 30)