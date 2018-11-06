using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class FocusController : MonoBehaviour {
    public Canvas canvas;
    public int focusesCount = 0;
    public List<Focus> focuses;

    public void DisplayFocus(int id)
    {
        Focus focus = focuses.Find(f => f.id == id);

        switch (focus.focuseType)
        {
            case Focus.FocusType._360Image:
                break;
            case Focus.FocusType._2DImage:
                break;
            case Focus.FocusType._2DImage360Image:
                break;
            case Focus.FocusType.Text:
                break;
            case Focus.FocusType.Text2DImage:
                DisplayText2DImage(focus);
                break;
            case Focus.FocusType.Text360Image:
                break;
            case Focus.FocusType.Text2DImage360Image:
                break;
            default:
                break;
        }
    }

    private void DisplayText2DImage(Focus focus)
    {
        GameObject newObj = new GameObject();
        Image image = newObj.AddComponent<Image>();
        image.sprite = focus._2DImages.ElementAt(0);
        newObj.GetComponent<RectTransform>().SetParent(canvas.transform);
        newObj.SetActive(true);
    }
}
