extends RigidBody3D
func _process(_delta):
	if Input.is_action_pressed("ui_right"):
		linear_velocity.x = 1
	if Input.is_action_pressed('ui_left'):
		linear_velocity.x = -1
	if Input.is_action_just_pressed('ui_up'):
		linear_velocity.y = 5
