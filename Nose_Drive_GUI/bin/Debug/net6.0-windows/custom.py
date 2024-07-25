import sys
options_file_name = sys.argv[1]

import sys
key_list = sys.argv[2]

import json
from nosedrive import track_face

# Init Gamepad controller
import vgamepad as vg # https://pypi.org/project/vgamepad/   https://github.com/ViGEm/ViGEmBus
gamepad = vg.VX360Gamepad()


buttons = {
  "A": vg.XUSB_BUTTON.XUSB_GAMEPAD_A,
  "B": vg.XUSB_BUTTON.XUSB_GAMEPAD_B,
  "X": vg.XUSB_BUTTON.XUSB_GAMEPAD_X,
  "Y": vg.XUSB_BUTTON.XUSB_GAMEPAD_Y,
  "LB": vg.XUSB_BUTTON.XUSB_GAMEPAD_LEFT_SHOULDER,
  "RB": vg.XUSB_BUTTON.XUSB_GAMEPAD_RIGHT_SHOULDER,
  "Start": vg.XUSB_BUTTON.XUSB_GAMEPAD_START,
  "Select": vg.XUSB_BUTTON.XUSB_GAMEPAD_BACK,
  "Dpad Right": vg.XUSB_BUTTON.XUSB_GAMEPAD_DPAD_RIGHT,
  "Dpad Left": vg.XUSB_BUTTON.XUSB_GAMEPAD_DPAD_LEFT,
  "Dpad Up": vg.XUSB_BUTTON.XUSB_GAMEPAD_DPAD_UP,
  "Dpad Down": vg.XUSB_BUTTON.XUSB_GAMEPAD_DPAD_DOWN,
  "Right Thumb": vg.XUSB_BUTTON.XUSB_GAMEPAD_RIGHT_THUMB,
  "Left Thumb": vg.XUSB_BUTTON.XUSB_GAMEPAD_LEFT_THUMB,
  "Home": vg.XUSB_BUTTON.XUSB_GAMEPAD_GUIDE,
}

triggerfunctions = {
  "LT": gamepad.left_trigger_float,
  "RT": gamepad.right_trigger_float
}


##################################
# IMPORT OPTIONS + Selected KEYS #
##################################
options_file = open(options_file_name) # Opening JSON file
options = json.load(options_file) # returns JSON object as a dictionary
options_file.close() # Closing file

key_import = open(key_list)
keyBinds = json.load(key_import) # returns JSON object as a dictionary
key_import.close() # Closing file



########
# LOGIC #
########
def logic(nose_x, nose_y, mouth_x, head_tilt, trigger_eyebrows, trigger_mouth_open):

  # zona_morta = 0

  nose_right = 0
  if nose_x > 0:
   nose_right = nose_x

  nose_left = 0
  if nose_x < 0:
   nose_left = -nose_x  

  nose_up = 0
  if nose_y < 0:
   nose_up = -nose_y

  nose_down = 0
  if nose_y > 0:
   nose_down = nose_y

  mouth_right = 0
  if mouth_x < 0:
   mouth_right = -mouth_x

  mouth_left = 0
  if mouth_x > 0:
   mouth_left = mouth_x

  # print(nose_left)

  analogMovements = {
    "nose_right": nose_right,
    "nose_left": nose_left,
    "nose_up": nose_up,
    "nose_down": nose_down,
    "mouth_right": mouth_right,
    "mouth_left": mouth_left
  }

  booleanMovements = {
    "eyebrows": trigger_eyebrows
  }

  analogs = {
    "Right": {
      "Right": 0,
      "Left": 0,
      "Up": 0,
      "Down": 0
    },
    "Left": {
      "Right": 0,
      "Left": 0,
      "Up": 0,
      "Down": 0
    }
  }

  using_right_joysticks = False
  using_left_joysticks = False

  for movement in keyBinds:

    virtual_input = keyBinds[movement]


    # JOYSTICKS
    if "Joystick" in virtual_input:
      keywords = virtual_input.split(" ")
      joyside = keywords[0]
      direction = keywords[2]
      if movement in analogMovements:
        analogs[joyside][direction] = analogMovements[movement]
      elif movement in booleanMovements:
        analogs[joyside][direction] = booleanMovements[movement]
      using_right_joysticks = joyside == "Right"
      using_left_joysticks = joyside == "Left"


    # BUTTONS
    if virtual_input in buttons:
      btn_code = buttons[virtual_input]
      press = False
      if movement in analogMovements:
        press = analogMovements[movement] > 0.5
      elif movement in booleanMovements:
        press = booleanMovements[movement]
      if press:
        gamepad.press_button(button=btn_code)
      else:
        gamepad.release_button(button=btn_code)

      
    # TRIGGERS
    if virtual_input == "LT" or virtual_input == "RT":
      if movement in analogMovements:
        triggerfunctions[virtual_input](analogMovements[movement])
      elif movement in booleanMovements:
        triggerfunctions[virtual_input](booleanMovements[movement])


  # Right Joystick
  if using_right_joysticks:    
    rx = analogs["Right"]["Right"] - analogs["Right"]["Left"]
    ry = analogs["Right"]["Up"] - analogs["Right"]["Down"]
    gamepad.right_joystick_float(x_value_float=rx, y_value_float=ry)

  # Left Joystick
  if using_left_joysticks:
    lx = analogs["Left"]["Right"] - analogs["Left"]["Left"]
    ly = analogs["Left"]["Up"] - analogs["Left"]["Down"]
    gamepad.left_joystick_float(x_value_float=lx, y_value_float=ly)

  # UPDATE
  gamepad.update()
  gamepad.reset()



#################
# START TRACKING #
#################
track_face(logic, options)
