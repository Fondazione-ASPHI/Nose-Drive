import sys
options_file_name = sys.argv[1]

import json
from Nose_Tracker import track_face

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

import keyboard


#################
# CUSTOM LOGIC #
#################
def logic(nose_x, nose_y, mouth_x, head_tilt, trigger_eyebrows, trigger_mouth_open):  
  
  if not tracker.connected:
    return

  # EYES
  screen_gaze = tracker.get_screen_gaze_info()
  screen_gaze_is_lost = screen_gaze.is_lost
  halfscreen_x = screen_width / 2
  halfscreen_y = screen_height / 2
  gaze_x = (screen_gaze.x - halfscreen_x)/halfscreen_x
  gaze_y = (screen_gaze.y - halfscreen_y)/halfscreen_y

  
  # Move forward backward with Vertical Nose
  gamepad.left_joystick_float(x_value_float=0, y_value_float=nose_y)  


  # Eyes for camera
  camx = 0
  camy = 0
  if gaze_y < -0.5 or gaze_y > 0.5:
    camy = gaze_y * 0.75
  if gaze_x < -0.5 or gaze_x > 0.5:
    camx = gaze_x * 0.9

  gamepad.right_joystick_float(x_value_float=camx, y_value_float=-camy)


  # Mouth Right or Left  
  # if mouth_x > 0.9:
  #   gamepad.press_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_A)
  # else:
  #   gamepad.release_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_A)
  # if mouth_x < -0.9:
  #   gamepad.press_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_B)
  # else:
  #   gamepad.release_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_B)


  # Head Tilt
  # if head_tilt > 0.9:
  #   gamepad.left_trigger_float(value_float=1)
  # else:
  #   gamepad.left_trigger_float(value_float=0)
  # if head_tilt < -0.9:
  #   gamepad.press_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_X)
  # else:
  #   gamepad.release_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_X)
    
  # Eyebrows
  # if trigger_eyebrows:
  #   gamepad.right_trigger_float(value_float=1)
  # else:
  #   gamepad.right_trigger_float(value_float=0)


  # Update gamepad
  gamepad.update()
  gamepad.reset()

#################
# IMPORT OPTIONS #
#################
options_file = open(options_file_name) # Opening JSON file
options = json.load(options_file) # returns JSON object as a dictionary
options_file.close() # Closing file


#################
# START TRACKING #
#################
track_face(logic, options)
