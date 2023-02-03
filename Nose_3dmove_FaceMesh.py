############################
# You can EDIT the following values
############################

nose_horizontal_sensibility = 10 # suggested values between 0 and 30
nose_vertical_sensibility = 30 # suggested values between 0 and 30

mouth_horizontal_sensibility = 50 # suggested values between 0 and 30
mouth_vertical_sensibility = 50 # suggested values between 0 and 30

eyebrows_threshold = 0.01
mouth_open_threshold = 0.5

calibration_time = 5 # in seconds



############################
# DON'T EDIT BELOW THIS LINE (unless you know what you are doing)
############################

from Nose_Tracker import track_face

# Init Gamepad controller
import vgamepad as vg # https://pypi.org/project/vgamepad/   https://github.com/ViGEm/ViGEmBus
gamepad = vg.VX360Gamepad()


#################
# CUSTOM LOGIC #
#################

def logic(nose_x, nose_y, mouth_x, mouth_y, trigger_eyebrows, trigger_mouth_open):  
  
  # Move forward or backward with Vertical Nose
  gamepad.left_joystick_float(x_value_float=0, y_value_float=nose_y)
  
  # Rotate Right-Left with Horizontal Nose and Up-Down with Vertical Mouth
  gamepad.right_joystick_float(x_value_float=-nose_x, y_value_float=0)
  
  # Mouth Right or Left to trigger A or B buttons
  if (mouth_x > 0.75):
    gamepad.press_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_A)  # Xbox360 A Button
  else:
    gamepad.release_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_A)  # Xbox360 A button  
  if (mouth_x < -0.75):
    gamepad.press_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_B)  # Xbox360 B Button
  else:
    gamepad.release_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_B)  # Xbox360 B button

  # Right Trigger with Eyebrows
  if (trigger_eyebrows):
    gamepad.right_trigger_float(value_float=1)
  else:
    gamepad.right_trigger_float(value_float=0)

  # Left Trigger with Mouth Open
  if (trigger_mouth_open):
    gamepad.left_trigger_float(value_float=1)
  else:
    gamepad.left_trigger_float(value_float=0)

  # Update gamepad
  gamepad.update()
  gamepad.reset()


###############################
###############################
###############################


options = {
  "logic": logic,
  "nose horizontal sensibility": nose_horizontal_sensibility,
  "nose vertical sensibility": nose_vertical_sensibility,
  "mouth horizontal sensibility": mouth_horizontal_sensibility,
  "mouth vertical sensibility": mouth_vertical_sensibility,
  "eyebrows threshold": eyebrows_threshold,
  "mouth open threshold": mouth_open_threshold,
  "calibration time": calibration_time
}

track_face(options)
