############################
# You can EDIT the following values
############################

options_file_name = "options.json"



############################
# DON'T EDIT BELOW THIS LINE (unless you know what you are doing)
############################

import json
from Nose_Tracker import track_face

# Init Gamepad controller
import vgamepad as vg # https://pypi.org/project/vgamepad/   https://github.com/ViGEm/ViGEmBus
gamepad = vg.VX360Gamepad()


#################
# CUSTOM LOGIC #
#################
def logic(nose_x, nose_y, mouth_x, mouth_y, head_tilt, trigger_eyebrows, trigger_mouth_open):  
  
  # Nose is left joystick
  gamepad.left_joystick_float(x_value_float=-nose_x, y_value_float=nose_y)
  
  # Mouth Right or Left to trigger A or B buttons
  if mouth_x > 0.01:
    gamepad.press_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_A)  # Xbox360 A Button
  else:
    gamepad.release_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_A)  # Xbox360 A button  
  if mouth_x < -0.01:
    gamepad.press_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_X)  # Xbox360 X Button
  else:
    gamepad.release_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_X)  # Xbox360 X button


  # Right Trigger with Eyebrows
  if trigger_eyebrows:
    gamepad.right_trigger_float(value_float=1)
  else:
    gamepad.right_trigger_float(value_float=0)

  # Left Trigger with Mouth Open
  if trigger_mouth_open:
    gamepad.press_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_Y)  # Xbox360 Y Button
  else:
    gamepad.release_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_Y)  # Xbox360 Y button

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
