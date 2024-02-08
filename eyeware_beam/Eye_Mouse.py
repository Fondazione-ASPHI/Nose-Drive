
# Init Mouse controller
import pyautogui
import win32api, win32con
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
  # pyautogui.moveTo(screen_gaze.x, screen_gaze.y)
  win32api.mouse_event(win32con.MOUSEEVENTF_MOVE | win32con.MOUSEEVENTF_ABSOLUTE, int(65536/1920*screen_gaze.x), int(65536/1080*screen_gaze.y), 0, 0)





  