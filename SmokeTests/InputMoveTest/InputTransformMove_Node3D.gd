extends Node3D

func _process(delta: float) -> void:
    var horizontal = Input.get_axis("ui_left", "ui_right")
    var vertical = Input.get_axis("ui_up", "ui_down")
    var move_speed: float = 4.0

    position = position + -transform.basis.z * vertical * move_speed * delta
    position = position + transform.basis.x * horizontal * move_speed * delta

    if Input.is_action_pressed("ui_accept"):
        position = position + transform.basis.y * move_speed * delta

    if Input.is_key_pressed(KEY_C):
        position = position + -transform.basis.y * move_speed * delta
