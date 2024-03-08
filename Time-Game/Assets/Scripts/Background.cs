using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public float speed;
    [SerializeField]
    private Renderer backgroundRenderer;
    private bool isCharacterMovingright = false;
    private bool isCharacterMovingleft = false;
    private void Start()
    {
        MovingCharacter movingCharacter = FindAnyObjectByType<MovingCharacter>();
        isCharacterMovingright = movingCharacter.movingCharacterright;
        MovingCharacter movingCharacter2 = FindAnyObjectByType<MovingCharacter>();
        isCharacterMovingleft = movingCharacter.movingCharacterleft;
    }
    void Update()
    {
        MovingCharacter movingCharacter = FindAnyObjectByType<MovingCharacter>();
        isCharacterMovingright = movingCharacter.movingCharacterright;
        MovingCharacter movingCharacter2 = FindAnyObjectByType<MovingCharacter>();
        isCharacterMovingleft = movingCharacter.movingCharacterleft;
        if (isCharacterMovingright)
        {
            backgroundRenderer.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0);
        }
        else if (isCharacterMovingleft)
        {
            backgroundRenderer.material.mainTextureOffset -= new Vector2(speed * Time.deltaTime, 0);
        }
    }
    public void StartMovingBackground()
    {
        isCharacterMovingright = true;
        isCharacterMovingleft = true;
    }

  
    public void StopMovingBackground()
    {
        isCharacterMovingright = false;
        isCharacterMovingleft = false;
    }
}
