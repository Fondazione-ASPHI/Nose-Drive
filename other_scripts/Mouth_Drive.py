import sys
options_file_name = sys.argv[1]

import json
from Nose_Tracker import track_face

# Init Gamepad controller
import vgamepad as vg # https://pypi.org/project/vgamepad/   https://github.com/ViGEm/ViGEmBus
gamepad = vg.VX360Gamepad()


#################
# NOSE #
#################
def logic(nose_x, nose_y, mouth_x, head_tilt, trigger_eyebrows, trigger_mouth_open):
  
  if trigger_eyebrows:
    gamepad.right_trigger_float(value_float=1)
    gamepad.left_trigger_float(value_float=0)
  else:
    gamepad.left_trigger_float(value_float=1)
    gamepad.right_trigger_float(value_float=0)  
  
  gamepad.left_joystick_float(x_value_float=-mouth_x, y_value_float=0)

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