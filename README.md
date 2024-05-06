<h1>Water Shader Engine Comparison</h1>
<h3>Unity</h3>
<img width="903" alt="UnityWater" src="/References/UnityWater.png">
<h3>Unreal</h3>
<img width="903" alt="UnityWater" src="/References/UnrealWater.png">

<h2>Water shader implementation</h2>
<p>To create realistic looking waves, I researched common methods used in video games and chose the Gerstner Wave formula, because it is realistic and has enough complexity to make a measurable impact on the performance. I followed a YouTube tutorial to implement it into Unity using Shader Graph. The variables didn’t seem to make an impact on performance, so I tweaked them to my liking. Next, I created the Unreal project and changed the settings to turn off post processing, to match it as close to Unity as possible. My next goal was to create the shader in Unreal which was the most time-consuming part of this assignment, because there were some differences in the material settings, missing functions, different coordinate spaces and difference in the normals.</p>

<h2>Links</h2>
<a href="https://www.youtube.com/watch?v=V4yZigMSLiU">Inspiration</a>
<br>
<a href="https://www.youtube.com/watch?v=Awd1hRpLSoI">Unity Tutorial</a>
<br>
<a href="https://docs.google.com/spreadsheets/d/e/2PACX-1vT80uWBKb73ku9S5hPhv6_zbwnhXyaa934AvZXso1GGOdYo_qHmZuMw1ggZSFw_zXzQPYyYwGBTyM9D/pubhtml">Charts</a>

<h2>Specs</h2>
<p>AMD Radeon 5700XT
<br>AMD Ryzen 7 3700X
<br>32 GB Ram</p>

<h2>Testing</h2>
<i>FPS Difference column is Opaque vs Translucent</i>
<img width="900" alt="UnityWater" src="/References/UnityChart3.png">
<img width="900" alt="UnityWater" src="/References/UnrealChart3.png">
<img width="900" alt="UnityWater" src="/References/TranslucentCompare.png">
<img width="900" alt="UnityWater" src="/References/NonTranslucentCompare.png">
<p>I tested using from 1 to 20 planes each of which are ~6 million tris without the shader, with the shader(Translucenct) and with the shader(Opaque). Firstly I tested both engines with their default lit material to see how triangle count impacts performance. And then I tested with the water shader to see how efficient the built-in shader graph editors are. Unity had an overall lower FPS than Unreal but it we look at the patterns between both engines we can see that Unity was better at rendering the opaque shader than the translucent one with the performance being almost identical to the default material. Unreal on the other hand was the opposite - the translucent shader performed better than the opaque one, but both made a measurable impact on the FPS compared to the default material, unlike Unity.

<h2>Conclusion</h2>
<p>It appears that Unreal Engine is overall more performant with high poly counts and even when using the heavier opaque version of the shader, which could be the result of a lot of factors. But if we ignore that overall difference, Unity is really efficient at rendering the opaque water shader</p>
