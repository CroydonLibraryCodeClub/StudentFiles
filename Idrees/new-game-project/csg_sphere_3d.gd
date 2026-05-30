extends RigidBody3D
func _process(_delta):
	if Input.is_action_pressed("ui_right"):
		apply_force(Vector3(1, 0, 0))
	if Input.is_action_pressed('ui_left'):
		apply_force(Vector3(-1, 0, 0))
	if Input.is_action_just_pressed('ui_up'):
		linear_velocity.y = 5
