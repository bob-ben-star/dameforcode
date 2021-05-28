using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine.Unity;
using UnityEngine.UI;

public class AniScript : MonoBehaviour
{
    public SkeletonAnimation skeletonAnimation;
    public Text Txt;
    private void Start()
    {
      
        Txt.text = skeletonAnimation.AnimationName;
    }
    // Start is called before the first frame update
    public void Play()
    {
        skeletonAnimation.timeScale = 1;
    }

    // Update is called once per frame
    public void Pause()
    {
        skeletonAnimation.timeScale = 0; 
    }

    public void Switch()
    {
        if (skeletonAnimation.AnimationName == "main")
        {
            //skeletonAnimation.AnimationName = "blink";
            skeletonAnimation.state.SetAnimation(0, "blink",true);
        }
        else
        {
            //skeletonAnimation.AnimationName = "main";
            skeletonAnimation.state.SetAnimation(0, "main", true);
        }

        Txt.text = skeletonAnimation.AnimationName;

    }

    public void ChangeFlipX()
    {
        //skeletonAnimation.skeleton.FlipX = !skeletonAnimation.skeleton.FlipX;
        skeletonAnimation.skeleton.ScaleX = -skeletonAnimation.skeleton.ScaleX;


    }

    private void Update()
    {
        Debug.Log(skeletonAnimation.state.GetCurrent(0));
    }
}
