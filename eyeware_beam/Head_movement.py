from eyeware.client import TrackerClient
import time
import numpy as np

tracker = TrackerClient()


# Function to normalize an angle in radians to a -1 to 1 scale
def normalize_pitch_to_unit_range(pitch_deg):
  pitch_rad = np.radians(pitch_deg)
  # Assuming the pitch range is -π/2 to π/2 (-90 to 90 degrees)
  # Normalize the pitch to a -1 to 1 range
  normalized_value = pitch_rad / (np.pi / 2)
  # Ensure the value is clamped between -1 and 1 to handle any outliers
  normalized_value = np.clip(normalized_value, -1, 1)
  return normalized_value



while True:
  if not tracker.connected:
    continue

  
  head_pose = tracker.get_head_pose_info()
  head_is_lost = head_pose.is_lost

  # print(head_pose.transform.rotation)
  # Assuming R is your 3x3 rotation matrix
  # R = np.array([[r11, r12, r13], [r21, r22, r23], [r31, r32, r33]])
  R = head_pose.transform.rotation

  # Calculate Pitch
  pitch = np.arcsin(-R[1, 2])

  # Calculate Yaw
  yaw = np.arctan2(R[0, 2], R[2, 2])

  # Calculate Roll (if needed)
  roll = np.arctan2(R[1, 0], R[1, 1])

  # Convert radians to degrees, if preferred
  pitch_deg = np.degrees(pitch)
  yaw_deg = np.degrees(yaw)
  roll_deg = np.degrees(roll)

  # print(f"Pitch: {pitch_deg} degrees")
  # print(f"Yaw: {yaw_deg} degrees")
  # print(f"Roll: {roll_deg} degrees")
  head_x = head_pose.transform.translation[0] * 10
  head_y = head_pose.transform.translation[1] * 30 + 3
  print(head_x, head_y)


  # print(gaze_x, gaze_y)
  # time.sleep(1 / 30)