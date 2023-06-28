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
  gamepad.right_joystick_float(x_value_float=-nose_x, y_value_float=mx)

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
  if keyboard.is_pressed('space'):
    gamepad.press_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_Y)
  else:
    gamepad.release_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_Y)

  if keyboard.is_pressed('x'):
    gamepad.press_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_X)
  else:
    gamepad.release_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_X) 
  
  if keyboard.is_pressed('escape'):
    gamepad.press_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_START)
  else:
    gamepad.release_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_START)  
  
  if keyboard.is_pressed('p'):
    gamepad.press_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_B)
  else:
    gamepad.release_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_B)
  
  if keyboard.is_pressed('o') or keyboard.is_pressed('q'):
    gamepad.press_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_A)
  else:
    gamepad.release_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_A)
  
  if keyboard.is_pressed('u'):
    gamepad.right_trigger_float(value_float=1)
  else:
    gamepad.right_trigger_float(value_float=0)

  if keyboard.is_pressed('i'):
    gamepad.left_trigger_float(value_float=1)
  else:
    gamepad.left_trigger_float(value_float=0)

  if keyboard.is_pressed('y'):
    gamepad.press_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_RIGHT_SHOULDER)
  else:
    gamepad.release_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_RIGHT_SHOULDER)
  
  if keyboard.is_pressed('t'):
    gamepad.press_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_LEFT_SHOULDER)
  else:
    gamepad.release_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_LEFT_SHOULDER)

  if keyboard.is_pressed('r'):
    gamepad.press_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_LEFT_THUMB)
  else:
    gamepad.release_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_LEFT_THUMB)

  if keyboard.is_pressed('e'):
    gamepad.press_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_RIGHT_THUMB)
  else:
    gamepad.release_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_RIGHT_THUMB)

  if keyboard.is_pressed('d'):
    gamepad.press_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_DPAD_RIGHT)
  else:
    gamepad.release_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_DPAD_RIGHT)
  
  if keyboard.is_pressed('w'):
    gamepad.press_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_DPAD_UP)
  else:
    gamepad.release_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_DPAD_UP)
  
  if keyboard.is_pressed('s'):
    gamepad.press_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_DPAD_DOWN)
  else:
    gamepad.release_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_DPAD_DOWN)
  
  if keyboard.is_pressed('a'):
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
