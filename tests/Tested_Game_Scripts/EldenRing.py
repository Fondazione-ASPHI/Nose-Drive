import sys
options_file_name = sys.argv[1]

import json
from Nose_Tracker import track_face

# Init Gamepad controller
import vgamepad as vg # https://pypi.org/project/vgamepad/   https://github.com/ViGEm/ViGEmBus
gamepad = vg.VX360Gamepad()

import keyboard


#################
# CUSTOM LOGIC #
#################
def logic(nose_x, nose_y, mouth_x, head_tilt, trigger_eyebrows, trigger_mouth_open):  
  
  # Move forward backward with Vertical Nose
  gamepad.left_joystick_float(x_value_float=0, y_value_float=nose_y)  

  # Rotate Right-Left with Horizontal Nose
  # Mouth Right or Left  
  mx = 0
  if mouth_x > 0.9:
    mx = 0.75
  elif mouth_x < -0.9:
    mx = -0.75
  else:
    mx = 0
  gamepad.right_joystick_float(x_value_float=nose_x, y_value_float=mx)

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
  if trigger_eyebrows:
    gamepad.right_trigger_float(value_float=1)
  else:
    gamepad.right_trigger_float(value_float=0)


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
