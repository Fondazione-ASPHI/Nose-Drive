# BEAM EYE TRACKER
Thanks to [BEAM EYE TRACKER](https://beam.eyeware.tech/) we are now able to simulate gamepad and mouse/keyboard inputs by moving our eyes!
* The scripts starting with "Eye" in their name makes use of this amazing feature.
* Of course, it is possible to combine mediapipe tracking of facial joints with the Eye gaze tracking to achieve even more customization! Note that in order to execute this kind of scripts (for example [Eye_3rd_Gamepad.py](Eye_3rd_Gamepad.py)) a software like "[Split Cam](https://splitcam.com/)" is required, because the webcam image should go to both Beam Eyetracker software and Python CV2 library at the same time.

# BUILD instructions
To compile these files:
pyinstaller -F --add-data ViGEmClient.dll;. Eye_Drive.py
