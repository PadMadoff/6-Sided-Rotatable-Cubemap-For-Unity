using UnityEngine;

public class AnimCubemapRotation : MonoBehaviour
{
    public Vector2 StartPosition; // Начальная позиция (углы)

    public Vector2 speed; // Скорость ротации по X и Y

    private void Start()
    {
        // Устанавливаем начальное значение ротации в скайбокс
        RenderSettings.skybox.SetVector("_RotationVector", new Vector4(StartPosition.x, StartPosition.y, 0, 0));
    }

    private void FixedUpdate()
    {
        // Рассчитываем новое значение ротации
        Vector2 currentRotation = StartPosition + new Vector2(Time.timeSinceLevelLoad * speed.x, Time.timeSinceLevelLoad * speed.y);

        // Устанавливаем новое значение в скайбокс
        RenderSettings.skybox.SetVector("_RotationVector", new Vector4(currentRotation.x, currentRotation.y, 0, 0));
    }
    private void OnDisable()
    {
        // При отключении скрипта возвращаем начальную позицию
        RenderSettings.skybox.SetVector("_RotationVector", new Vector4(StartPosition.x, StartPosition.y, 0, 0));
    }
}

