import sys
options_file_name = sys.argv[1]

import json
from Nose_Tracker import track_face
import win32api, win32con


#################
# CUSTOM LOGIC #
#################
def logic(nose_x, nose_y, mouth_x, head_tilt, trigger_eyebrows, trigger_mouth_open):  
  
  # NOSE MOUSE
  x, y = 0, 0 
  if nose_x < -0.75 or nose_x > 0.75: # Left
    x = int(-nose_x * 30)
  if nose_y < -0.75 or nose_y > 0.75: # Right
    y = int(nose_y * 20)
  win32api.mouse_event(win32con.MOUSEEVENTF_MOVE, x, y, 0, 0)



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
