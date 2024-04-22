from eyeware.client import TrackerClient

tracker = TrackerClient()

# Make sure that the connection with the tracker server (Eyeware application) is up and running.

import pyautogui
screen_width, screen_height = pyautogui.size()

import keyboard as kb
import pynput
from pynput.keyboard import Key
from pynput.mouse import Button
keyboard = pynput.keyboard.Controller()
mouse = pynput.mouse.Controller()


# MAIN LOOP
dead_zone = 0.5
looking_right = False
looking_left = False
while True:
  if not tracker.connected:
    continue
  
  screen_gaze = tracker.get_screen_gaze_info()
  screen_gaze_is_lost = screen_gaze.is_lost
  halfscreen_x = screen_width / 2
  halfscreen_y = screen_height / 2
  gaze_x = (screen_gaze.x - halfscreen_x)/halfscreen_x
  gaze_y = (screen_gaze.y - halfscreen_y)/halfscreen_y

  if not screen_gaze_is_lost:  

    if gaze_x > dead_zone and not looking_right:
      looking_right = True      
      keyboard.press(Key.down)
      print("looking right")
    elif gaze_x < dead_zone and looking_right:
      looking_right = False
      keyboard.release(Key.down)
      print("NOT looking right")
      
    if gaze_x < -dead_zone and not looking_left:      
      looking_left = True
      keyboard.press("x")
      print("looking left")
    elif gaze_x > -dead_zone and looking_left:
      looking_left = False
      keyboard.release("x")
      print("NOT looking left")

