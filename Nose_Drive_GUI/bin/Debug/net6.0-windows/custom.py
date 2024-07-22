import sys
options_file_name = sys.argv[1]

import sys
key_list = sys.argv[2]



import json
from nosedrive import track_face

# Init Gamepad controller
import vgamepad as vg # https://pypi.org/project/vgamepad/   https://github.com/ViGEm/ViGEmBus
gamepad = vg.VX360Gamepad()





tasti = {
  "A": vg.XUSB_BUTTON.XUSB_GAMEPAD_A,
  "B": vg.XUSB_BUTTON.XUSB_GAMEPAD_B,
  "X": vg.XUSB_BUTTON.XUSB_GAMEPAD_X,
  "Y": vg.XUSB_BUTTON.XUSB_GAMEPAD_Y,
  #"LB": vg.XUSB_GAMEPAD_LEFT_SHOULDER,
  #"RB": vg.XUSB_GAMEPAD_LEFT_SHOULDER,
  #"Start": vg.XUSB_GAMEPAD_START,
  #"Select": vg.XUSB_GAMEPAD_BACK,
  "Dpad Right": vg.XUSB_BUTTON.XUSB_GAMEPAD_DPAD_RIGHT,
  "Dpad Left": vg.XUSB_BUTTON.XUSB_GAMEPAD_DPAD_LEFT,
  "Dpad Up": vg.XUSB_BUTTON.XUSB_GAMEPAD_DPAD_UP,
  "Dpad Down": vg.XUSB_BUTTON.XUSB_GAMEPAD_DPAD_DOWN,
  #"Right Thumb": vg.XUSB_GAMEPAD_RIGHT_THUMB,
  #"Left Thumb": vg.XUSB_GAMEPAD_LEFT_THUMB,
  #"Home": vg.XUSB_GAMEPAD_GUIDE,
}
#tasti["A"]





##################################
# IMPORT OPTIONS + Selected KEYS #
##################################
options_file = open(options_file_name) # Opening JSON file
options = json.load(options_file) # returns JSON object as a dictionary
options_file.close() # Closing file

key_import = open(key_list)
keyBinds = json.load(key_import) # returns JSON object as a dictionary
key_import.close() # Closing file



############
# Funzioni #
############
#def tasto()





########
# NOSE #
########
def logic(nose_x, nose_y, mouth_x, head_tilt, trigger_eyebrows, trigger_mouth_open):

 

  zona_morta = 0.4

  #if(keyBinds["nose_right"] in tasti)

  for movement in keyBinds:
    value = keyBinds[movement]
    

    if not value:     #se vuoto / 'non assegnato' > salta
      continue

    if value in tasti:          #se tasto (input digitale) > ...
      comando = tasti[value]
      if movement == "nose_right":
        if nose_x > 0.6:                  
          print(comando)
          gamepad.press_button(button=comando)
        else:
          gamepad.release_button(button=comando)

      if movement == "nose_left":
        if nose_x < -0.6:                  
          print(comando)
          gamepad.press_button(button=comando)
        else:
          gamepad.release_button(button=comando)
      
      if movement == "nose_up":
        if nose_y < -0.6:                  
          print(comando)
          gamepad.press_button(button=comando)
        else:
          gamepad.release_button(button=comando)
        
      if movement == "nose_down":
        if nose_y > 0.6:                  
          print(comando)
          gamepad.press_button(button=comando)
        else:
          gamepad.release_button(button=comando)


    elif "Joystick" in value:                             # se non digitale, allora è analogico > ...

      Y = False
      X = False

      comando = value

      if movement == "nose_right" and nose_x > zona_morta:                 
        print(comando)
        X = True
      else:
        print("<<<")
          
 
      if movement == "nose_left" and nose_x < -zona_morta:
        print(comando)
        X = True
      else:
        print(">>>")

      
      if movement == "nose_up" and nose_y < -zona_morta:
        print(comando)
        Y = True
      else:
        print("^^^")
        
      if movement == "nose_down" and nose_y > zona_morta:
        print(comando)
        Y = True
      else:
        print("vvv")

      if "Left" in value:
        if X and Y:
          gamepad.left_joystick_float(x_value_float=nose_x, y_value_float= -nose_y)

        if X and not Y:
          gamepad.left_joystick_float(x_value_float=nose_x, y_value_float=0.0)
        
        if not X and Y:
          gamepad.left_joystick_float(x_value_float=0.0, y_value_float= -nose_y)

      else:
        if X and Y:
          gamepad.right_joystick_float(x_value_float=nose_x, y_value_float= -nose_y)

        if X and not Y:
          gamepad.right_joystick_float(x_value_float=nose_x, y_value_float=0.0)
        
        if not X and Y:
          gamepad.right_joystick_float(x_value_float=0.0, y_value_float= -nose_y)
      

    elif "LT" in value or "RT" in value:

      comando = value       #'comando' potrebbe essere rimosso, ma è più chiaro il ragionamento dato che viene usato prima

      if "Left" in value:
        if movement == "nose_right" and nose_x > zona_morta:                 
          print(comando)
          gamepad.left_trigger_float(value_float= nose_x)
        
        if movement == "nose_left" and nose_x < -zona_morta:
          print(comando)
          gamepad.left_trigger_float(value_float= -nose_x)
        
        if movement == "nose_up" and nose_y < -zona_morta:
          print(comando)
          gamepad.left_trigger_float(value_float= -nose_y)  

        if movement == "nose_down" and nose_y > zona_morta:
          print(comando)
          gamepad.left_trigger_float(value_float= nose_y)
      

      else:
        if movement == "nose_right" and nose_x > zona_morta:                 
          print(comando)
          gamepad.right_trigger_float(value_float= nose_x)
        
        if movement == "nose_left" and nose_x < -zona_morta:
          print(comando)
          gamepad.right_trigger_float(value_float= -nose_x)
        
        if movement == "nose_up" and nose_y < -zona_morta:
          print(comando)
          gamepad.right_trigger_float(value_float= -nose_y)  

        if movement == "nose_down" and nose_y > zona_morta:
          print(comando)
          gamepad.right_trigger_float(value_float= nose_y)








      #else:
      #  print("ERR")



        #elif value in leve_analogiche:
        #    comando = leve_analogiche[value]
        #    print(f"Il comando '{key}' corrisponde a '{comando}' nel dizionario delle leve analogiche")
        #    # Supponiamo che 'valore' sia il valore da 0.0 a 1.0 per le leve analogiche
        #    esegui_azione_analogica(comando, valore=0.5)  # Esempio di valore
        
    #     else:
    #         print(f"Il comando '{key}' con valore '{value}' non è riconosciuto nei dizionari")
    # else:
    #     print(f"Il comando '{key}' non è mappato (valore vuoto)")



  #gamepad.left_joystick_float(x_value_float=nose_x, y_value_float=0)
  #if nose_y > 0:
  #  # controller.release(Key.down)
  #  gamepad.right_trigger_float(value_float=nose_y)
  #elif nose_y < 0:
  #  # controller.press(Key.down)
  #  gamepad.left_trigger_float(value_float=1) # value_float=-y if you want analog brake
  gamepad.update()
  gamepad.reset()






#################
# START TRACKING #
#################
track_face(logic, options)