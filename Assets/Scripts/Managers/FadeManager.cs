using UnityEngine;
using System.Collections;

public class FadeManager : MonoBehaviour
{
    public Texture2D fadeOutTexture; // Texture that will overlay the scene
    public float fadeSpeed = 0.8f;

    private int drawDepth = -1000; // Texture's order in the draw hierarchy : a low # means it renders on top
    private float alpha = 1.0f;
    private int fadeDir = -1; // -1 Fade in , 1 Fade out


    void OnGui()
    {
        // fade out/in the alpha value using a direction, a speed and Time.deltatime to convert the operation to seconds
        alpha += fadeDir * fadeSpeed * Time.deltaTime;
        // Force the number between 0 and 1 because GUI.Color uses alpha values between 0 and 1
        alpha = Mathf.Clamp01(alpha);

        // set color of our GUI (texture). All color values remain the same & the Alpha is set to the alpha Variable
        GUI.color = new Color(GUI.color.r, GUI.color.g, GUI.color.b, alpha); // set the alpha value
        GUI.depth = drawDepth; // make the black texture render on top (drawn last)
        GUI.DrawTexture (new Rect (0,0, Screen.width, Screen.height), fadeOutTexture); //draw the texture to fit the entire screen area
    }

    //sets fadeDir to the direction paremeter making the scene fade in if -1
    public float BeginFade(int direction)
    {
        fadeDir = direction;
        return (fadeSpeed); //return the fadeSpeed variable so it's easy to time the Application.LoadLeve();
    }
    
    //OnLevelWas loaded is called when is level is loaded. It takes loaded level index (int) as a para,eter so you can limit the fade in to certain scenes
    void OnLevelWasLoaded()
    {
        BeginFade(-1);
    }
}