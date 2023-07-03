import sys
options_file_name = sys.argv[1]

import json
from Nose_Tracker import track_face

# Init Gamepad controller
import vgamepad as vg # https://pypi.org/project/vgamepad/   https://github.com/ViGEm/ViGEmBus
gamepad = vg.VX360Gamepad()

import keyboard
mode = "move"

#################
# CUSTOM LOGIC #
#################
def logic(nose_x, nose_y, mouth_x, head_tilt, trigger_eyebrows, trigger_mouth_open):  
  global mode

  if keyboard.is_pressed('m'):
    mode = "aim"
    print(mode)
  if keyboard.is_pressed('b'):
    mode = "move"
    print(mode)

  if mode == "move":
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
    gamepad.right_joystick_float(x_value_float=-nose_x, y_value_float=mx)

  elif mode == "aim":
    gamepad.right_joystick_float(x_value_float=-nose_x, y_value_float=-nose_y)


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


  # Convert KEYBOARD to Controller (for Vocal Commands)  
  if keyboard.is_pressed('0'):
    gamepad.press_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_A)
  else:
    gamepad.release_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_A)

  if keyboard.is_pressed('1'):
    gamepad.press_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_B)
  else:
    gamepad.release_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_B)
  
  if keyboard.is_pressed('2'):
    gamepad.press_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_X)
  else:
    gamepad.release_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_X) 

  if keyboard.is_pressed('3'):
    gamepad.press_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_Y)
  else:
    gamepad.release_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_Y) 

  if keyboard.is_pressed('4'):
    gamepad.press_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_START)
  else:
    gamepad.release_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_START)

  if keyboard.is_pressed('5'):
    gamepad.press_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_BACK)
  else:
    gamepad.release_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_BACK)

  if keyboard.is_pressed('6'):
    gamepad.right_trigger_float(value_float=1)
  else:
    gamepad.right_trigger_float(value_float=0)

  if keyboard.is_pressed('7'):
    gamepad.left_trigger_float(value_float=1)
  else:
    gamepad.left_trigger_float(value_float=0)

  if keyboard.is_pressed('8'):
    gamepad.press_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_RIGHT_SHOULDER)
  else:
    gamepad.release_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_RIGHT_SHOULDER)
  
  if keyboard.is_pressed('9'):
    gamepad.press_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_LEFT_SHOULDER)
  else:
    gamepad.release_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_LEFT_SHOULDER)

  if keyboard.is_pressed('+'):
    gamepad.press_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_LEFT_THUMB)
  else:
    gamepad.release_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_LEFT_THUMB)

  if keyboard.is_pressed('-'):
    gamepad.press_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_RIGHT_THUMB)
  else:
    gamepad.release_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_RIGHT_THUMB)

  if keyboard.is_pressed('right'):
    gamepad.press_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_DPAD_RIGHT)
  else:
    gamepad.release_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_DPAD_RIGHT)
  
  if keyboard.is_pressed('up'):
    gamepad.press_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_DPAD_UP)
  else:
    gamepad.release_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_DPAD_UP)
  
  if keyboard.is_pressed('down'):
    gamepad.press_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_DPAD_DOWN)
  else:
    gamepad.release_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_DPAD_DOWN)
  
  if keyboard.is_pressed('left'):
    gamepad.press_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_DPAD_LEFT)
  else:
    gamepad.release_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_DPAD_LEFT)


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
