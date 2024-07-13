import sys
options_file_name = sys.argv[1]
target_logic = sys.argv[2]

import json
from nosedrive import track_face

# Init Gamepad controller
import vgamepad as vg # https://pypi.org/project/vgamepad/   https://github.com/ViGEm/ViGEmBus
gamepad = vg.VX360Gamepad()

import keyboard as kb



#################
# Drive #
#################
def drive(nose_x, nose_y, mouth_x, head_tilt, trigger_eyebrows, trigger_mouth_open):
  gamepad.left_joystick_float(x_value_float=nose_x, y_value_float=0)
  if nose_y > 0:
    # controller.release(Key.down)
    gamepad.right_trigger_float(value_float=nose_y)
  elif nose_y < 0:
    # controller.press(Key.down)
    gamepad.left_trigger_float(value_float=1) # value_float=-y if you want analog brake
  gamepad.update()
  gamepad.reset()



#################
# 3D Movement #
#################
mode = "Move" # or "Aim"
def move3d(nose_x, nose_y, mouth_x, head_tilt, trigger_eyebrows, trigger_mouth_open):  
  global mode
  x, y = 0, 0

  if kb.is_pressed("8"):
    mode = "Move"
  elif kb.is_pressed("9"):
    mode = "Aim"

  if mode == "Move":
    # Camera with HORIZONTAL NOSE
    if nose_x < -0.2 or nose_x > 0.2: # Left
      gamepad.right_joystick_float(x_value_float=nose_x, y_value_float=0)

    # Movement with VERTICAL NOSE
    gamepad.left_joystick_float(x_value_float=0, y_value_float=nose_y)

  elif mode == "Aim":    
    if nose_x < -0.2 or nose_x > 0.2: # Left
      x = nose_x
    if nose_y < -0.2 or nose_y > 0.2: # Right
      y = nose_y
    gamepad.right_joystick_float(x_value_float=x, y_value_float=y)

  gamepad.update()
  gamepad.reset()



#################
# Platform #
#################
def platform(nose_x, nose_y, mouth_x, head_tilt, trigger_eyebrows, trigger_mouth_open):

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
logics = {
  "Drive": drive,
  "3D_Movement": move3d,
  "Platform": platform
}
logic = logics[target_logic]
track_face(logic, options)