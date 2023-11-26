using UnityEngine;
using UnityEngine.UI;

public class ImageButton : MonoBehaviour
{
    public Image image;
    public Button button;

    private bool isImageOpen = false;

    private void Start()
    {
        button.onClick.AddListener(ToggleImage);
    }

    private void Update()
    {
        if (Input.anyKeyDown && isImageOpen)
        {
            CloseImage();
        }
    }

    private void ToggleImage()
    {
        if (!isImageOpen)
        {
            OpenImage();
        }
        else
        {
            CloseImage();
        }
    }

    private void OpenImage()
    {
        image.gameObject.SetActive(true);
        isImageOpen = true;
    }

    private void CloseImage()
    {
        image.gameObject.SetActive(false);
        isImageOpen = false;
    }
}
