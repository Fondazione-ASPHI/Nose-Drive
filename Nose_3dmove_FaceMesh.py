############################
# You can EDIT the following values
############################

nose_horizontal_sensibility = 15 # suggested values between 0 and 30
nose_vertical_sensibility = 30 # suggested values between 0 and 30

mouth_horizontal_sensibility = 20 # suggested values between 0 and 30
mouth_vertical_sensibility = 35 # suggested values between 0 and 30

calibration_time = 5 # in seconds



############################
# DON'T EDIT BELOW THIS LINE (unless you know what you are doing)
############################

from Nose_Tracker import track_face


# Init Gamepad controller
import vgamepad as vg # https://pypi.org/project/vgamepad/   https://github.com/ViGEm/ViGEmBus
gamepad = vg.VX360Gamepad()


#################
# NOSE #
#################
def nose(x, y):  
  gamepad.left_joystick_float(x_value_float=-x, y_value_float=y)


def mouth(x, y):
  gamepad.right_joystick_float(x_value_float=-x, y_value_float=y)
  

def endframe():
  gamepad.update()
  gamepad.reset()


###############################
###############################
###############################

options = {
  "nose logic": nose,
  "mouth logic": mouth,
  "end frame logic": endframe,
  "nose horizontal sensibility": nose_horizontal_sensibility,
  "nose vertical sensibility": nose_vertical_sensibility,
  "mouth horizontal sensibility": mouth_horizontal_sensibility,
  "mouth vertical sensibility": mouth_vertical_sensibility,
  "calibration time": calibration_time
}


track_face(options)