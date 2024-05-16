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


# MAIN LOOP
while True:
  if not tracker.connected:
    continue

  
  screen_gaze = tracker.get_screen_gaze_info()
  screen_gaze_is_lost = screen_gaze.is_lost
  halfscreen_x = screen_width / 2
  halfscreen_y = screen_height / 2
  gaze_x = (screen_gaze.x - halfscreen_x)/halfscreen_x
  gaze_y = (screen_gaze.y - halfscreen_y)/halfscreen_y
  
  if not screen_gaze_is_lost:  
    gamepad.left_joystick_float(x_value_float=gaze_x*2, y_value_float=0)
  
  gamepad.update()
  gamepad.reset()