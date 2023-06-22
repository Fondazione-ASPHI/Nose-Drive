import sys
options_file_name = sys.argv[1]

import json
from Nose_Tracker import track_face


# Init Mouse controller
import pyautogui
pyautogui.FAILSAFE = False
width, height = pyautogui.size()
print("Screen resolution:", width, "x", height)



#################
# NOSE #
#################
def logic(nose_x, nose_y, mouth_x, head_tilt, trigger_eyebrows, trigger_mouth_open):
  mouse_x = ((-nose_x + 1) / 2) * width
  mouse_y = ((nose_y + 1) / 2) * height
  pyautogui.moveTo(mouse_x, mouse_y)





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





  