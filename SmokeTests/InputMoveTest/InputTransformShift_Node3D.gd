extends Node3D

func _process(delta: float) -> void:
    var horizontal = Input.get_axis("ui_left", "ui_right")
    var vertical = Input.get_axis("ui_up", "ui_down")
    var shift_speed: float = 4.0

    position = Vector3(
        position.x + horizontal * shift_speed * delta,
        position.y,
        position.z + -vertical * shift_speed * delta
    )

    if Input.is_action_pressed("ui_accept"):
        position = Vector3(
            position.x,
            position.y + shift_speed * delta,
            position.z
        )

    if Input.is_key_pressed(KEY_C):
        position = Vector3(
            position.x,
            position.y + -shift_speed * delta,
            position.z
        )
