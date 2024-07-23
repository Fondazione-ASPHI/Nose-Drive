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
#buttons["A"]

joyfunctions = {
  "Left": gamepad.left_joystick_float,
  "Right": gamepad.right_joystick_float
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

  zona_morta = 0

  analogMovements = {
    "nose_right": -nose_x,
    "nose_left": nose_x,
    "nose_up": -nose_y,
    "nose_down": nose_y,
    "mouth_right": -mouth_x,
    "mouth_left": mouth_x
  }

  booleanMovements = {
    "eyebrows": trigger_eyebrows
  }

  xy = [0, 0]
  directions = {
    "Right": 0,
    "Left": 0,
    "Up": 1,
    "Down": 1
  }


  for movement in keyBinds:

    virtual_input = keyBinds[movement]


    # JOYSTICKS
    if "Joystick" in virtual_input:
      keywords = virtual_input.split(" ")
      joyside = keywords[0]
      direction = keywords[2]
      if movement in analogMovements:
        xy[directions[direction]] = analogMovements[movement]
      elif movement in booleanMovements:
        xy[directions[direction]] = booleanMovements[movement]
      joyfunctions[joyside](x_value_float=xy[0], y_value_float=xy[1])


    # BUTTONS
    if virtual_input in buttons:
      btn_code = buttons[virtual_input]
      if movement in analogMovements:
        if analogMovements[movement] > 0.5:                  
          gamepad.press_button(button=btn_code)
        else:
          gamepad.release_button(button=btn_code)

      
    # TRIGGERS
    if "LT" in virtual_input or "RT" in virtual_input:
      if movement in analogMovements:
        triggerfunctions[virtual_input](analogMovements[movement])
      elif movement in booleanMovements:
        triggerfunctions[virtual_input](booleanMovements[movement])



  # UPDATE
  gamepad.update()
  gamepad.reset()



#################
# START TRACKING #
#################
track_face(logic, options)
