
# Init Mouse controller
import pyautogui
pyautogui.FAILSAFE = False
width, height = pyautogui.size()
print("Screen resolution:", width, "x", height)

from eyeware.client import TrackerClient
import time
import numpy as np

tracker = TrackerClient()



while True:
  if not tracker.connected:
    continue
  
  screen_gaze = tracker.get_screen_gaze_info()
  screen_gaze_is_lost = screen_gaze.is_lost
  pyautogui.moveTo(screen_gaze.x, screen_gaze.y)





  