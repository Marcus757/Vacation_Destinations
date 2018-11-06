using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[System.Serializable]
public class Focus : MonoBehaviour
{
    public int id;
    public string name;
    public enum FocusType
    {
        Text,
        Text2DImage,
        Text360Image,
        Text2DImage360Image,
        _360Image,
        _2DImage,
        _2DImage360Image
    };
    public FocusType focuseType;
    public bool isExpandable = false; // What is this for?
    public AudioClip dialog;
    List<Texture> _360Images;
    public UnityEvent unityEvent;
    public Focus nextFocus;

    #region 2D Images
    
    public enum ImageAnimationType
    {
        Single,
        Animated
    }

    [HideInInspector]
    public ImageAnimationType imageAnimation;
    public enum ImageFadeType
    {
        None,
        Fade
    }
    public ImageFadeType imageFade;
    public List<Sprite> _2DImages;

    [HideInInspector]
    public Vector3 imageStartLocation;

    [HideInInspector]
    public Vector3 imageEndLocation;

    [HideInInspector]
    public AnimationCurve imageAnimationCurve;
    #endregion

    #region Text
    public enum TextAnimationType
    {
        Single,
        Animated
    }

    [HideInInspector]
    public TextAnimationType textAnimation;

    public List<Text> visibleText;

    [HideInInspector]
    public Vector3 textStartLocation;

    [HideInInspector]
    public Vector3 textEndLocation;

    [HideInInspector]
    public AnimationCurve textAnimationCurve;
    #endregion
}
