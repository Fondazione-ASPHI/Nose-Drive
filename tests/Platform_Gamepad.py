#####
# THIS SCRIPT is mainly aimed at platform games, with nose controlling left gamepad analog joystick
# Other facial gestures such as raise eyebrows or mouth horizontal movement can be linked to other gamepad buttons
# PS: You could do the same with keyboard instead of gamepad. Look at "Head arrows" script as an example
#####


import sys
options_file_name = sys.argv[1]

import json
from nosedrive import track_face

# Init Gamepad controller
import vgamepad as vg # https://pypi.org/project/vgamepad/   https://github.com/ViGEm/ViGEmBus
gamepad = vg.VX360Gamepad()


#################
# CUSTOM LOGIC #
#################
def logic(nose_x, nose_y, mouth_x, head_tilt, trigger_eyebrows, trigger_mouth_open):

  # Nose is left joystick
  gamepad.left_joystick_float(x_value_float=nose_x, y_value_float=nose_y)
  
  # Mouth Right or Left to trigger A or B buttons
  if mouth_x > 0.9:
    gamepad.press_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_A)
  else:
    gamepad.release_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_A)  
  if mouth_x < -0.9:
    gamepad.press_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_B)
  else:
    gamepad.release_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_B)

  # Right Trigger with Eyebrows
  if trigger_eyebrows:
    gamepad.right_trigger_float(value_float=1)
  else:
    gamepad.right_trigger_float(value_float=0)

  # Left Trigger with Mouth Open
  # if trigger_mouth_open:
  #   gamepad.press_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_Y)
  # else:
  #   gamepad.release_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_Y)

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
