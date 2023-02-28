############################
# You can EDIT the following values
############################

options_file_name = "drive.json"



############################
# DON'T EDIT BELOW THIS LINE (unless you know what you are doing)
############################

import json
from Nose_Tracker import track_face


# Init Gamepad controller
import vgamepad as vg # https://pypi.org/project/vgamepad/   https://github.com/ViGEm/ViGEmBus
gamepad = vg.VX360Gamepad()


#################
# NOSE #
#################
def logic(nose_x, nose_y, mouth_x, head_tilt, trigger_eyebrows, trigger_mouth_open):
  gamepad.left_joystick_float(x_value_float=-nose_x, y_value_float=0)
  if nose_y > 0:
    # controller.release(Key.down)
    gamepad.right_trigger_float(value_float=nose_y)
  elif nose_y < 0:
    # controller.press(Key.down)
    gamepad.left_trigger_float(value_float=1) # value_float=-y if you want analog brake
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