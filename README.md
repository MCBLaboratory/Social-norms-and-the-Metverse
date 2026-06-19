<h1 align="center">
  Can Avatars Shape Sustainable Consumer Food Choices? Exploring Social Norms in Virtual Worlds
</h1>

<div align="center">
    <img src="https://github.com/MCBLaboratory/Social-norms-and-the-Metaverse/blob/main/2.Pictures/Picture1.jpg">
</div>


<h2>Overview</h2>
<p>
  This project provides an immersive, canteen environment to explore how virtual avatars, interact, guide, and even influence the purchasing behaviour of others in real-time.

</p>

<h2>Requirements</h2>
<ul>
  <li><b>Windows PC:</b> Tested on Windows 11 25H2</li>
  <li><b>Virtual Reality:</b> Tested with a Varjo XR3 & Meta Quest 3 VR headset</li>
  <li><b>Unity 2022.3.23f1 or higher </b></li>
  <li><b>Unity Hub</b></li>
  <li><b>(Inside-out tracking) SteamVR & min. 2x HTC/Valve Base Stations V1.0 or V2.0</b></li>
  </li>
</ul>

<h2>Getting Started</h2>

<p><strong>Note:</strong> On first launch, the main scene might appear hidden. To open it, go to <b>Assets → Scene → Scene.unity</b>.</p>

<ol>
  <li>Clone the repository or download the .zip from the green "Code" button:<br>
    <code>git clone https://github.com/MCBLaboratory/Social-norms-and-the-Metaverse</code>
  </li>
	<li>Open Unity Hub, click <em>Create New Project → Add Existing Project</em>, and select the cloned project folder. The first launch may take additional time due to rebuilding of the asset database.</li>
	<li>During first launch, make sure the required packages are installed via <b>Window - Package Manager</b>.</li>
	<li>The XR Device Simulator is enabled by default, which can be unselected via the <em>Scene Hierarchy - Setup - XR Device Simulator</em>.</li>
</ol>

<h2>Unity Versions & Dependencies</h2>
<ul>
  <li><b>Operating System:</b> Windows 10 or 11</li>
  <li><b>Unity Versions:</b>
    <ul>
      <li><b>Windows PC:</b> Tested with Unity <code>2022.3.23f1</code></li>
    </ul>
  </li>
  <li><b>Required Unity Packages:</b>
    <ol>
					    <li>
    <b>OpenXR:</b>
    <a href="https://github.com/needle-mirror/com.unity.xr.openxr" target="_blank">OpenXR</a>
  </li>
	    <li>
    <b>VarjoUnityXRPlugin:</b>
    <a href="https://github.com/varjocom/VarjoUnityXRPlugin" target="_blank">Varjo XR Unity Companion</a>
  </li>
<i></i>
      <li>Post Processing</li>
      <li>TextMeshPro</li>
	  <li>AI Navigation (v1.1.6 or higher)</li>
    </ol>
  </li>
</ul>

<h3>Included Scripts</h3>
<table border="1" cellpadding="8" cellspacing="0">
  <thead>
    <tr>
      <th>Script</th>
      <th>Description</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td><b>MainFile.cs</b></td>
      <td>Tracks the event data, including participant ID, group, chosen item and timestamps. 
	  See <a href="https://github.com/MCBLaboratory/Social-norms-and-the-Metaverse/tree/main/1.Unity/Assets/Data " target="_blank">Assets - Data</a> for an example.</td>
    </tr>
    <tr>
      <td><b>Eye-tracking.cs</b></td>
      <td>Contains the ability to capture eye tracking and track event data with a Varjo XR3 headset. Can be activated with <b>F1</b>. Data will be stored in Assets - EyeTracking.</td>
    </tr>
		 <tr>
      <td><b>GroupSpecific/GroupX.cs</b></td>
      <td>Controls the experiment layout and included choices, depending on the group selection.</td>
    </tr> 
	 <tr>
      <td><b>Checkout.cs</b></td>
      <td>Initialises the final choice of the participant during checkout (i.e., final event).</td>
    </tr> 
     <tr>
      <td><b>NPCAudioTrigger/Movement/Orientation/Dialogue/CustomNavMeshAgent.cs</b></td>
      <td>Controls the NPC logic, dialogue and movement.</td>
    </tr> 
  </tbody>
</table>

<h2>Scene</h2>

<p>
This scene simulates an interactive digital twin of a university canteen, developed to explore the hypothesised effects of the Metaverse-based social norms. Following a 2X2 design, each particpant has the option to choose either between a meatbased burger or a bean-based (vegetarian) burger. At the start of the experiment, participants can choose between four groups that influences their observed social norm type (descriptive norm (DN) vs. injunctive norm (IN)) and social norm format (immersive (EXP) vs. textual (TEXT)).
</p>
<p><b>Group 1:</b> Participants observe a queue of virtual avatars ahead of them, each elaborating on their decision to choose the sustainable meal.</p>
<p><b>Group 2:</b> The norm message for the descriptive norm–textual condition states that most people choose the sustainable option.</p>
<p><b>Group 3:</b> Participants are placed in a protest-like setting populated by virtual avatars advocating for more environmentally responsible food choices.</p>
<p><b>Group 4:</b> The norm message for the descriptive norm–textual condition indicates that choosing the sustainable option is the "right" thing to do.</p>

<h2>Miscellaneous</h2>
<ol>
  <li>The project is technically compatible with all major VR headsets (HTC, Meta/Oculus, Valve, WMR headsets).</li>
  <li>The game logic is written in C#.</li>
	<li>
    The project is configured for an <strong>OpenXR-compatible</strong> headset such as the Meta Quest line-up. The controller scheme is mapped for the
    <strong>Valve Index Controllers</strong>.
  </li>
  <li>
    To change the VR headset settings (e.g., add Meta Quest 3), disable
    <strong>Varjo</strong> and enable <strong>OpenXR</strong> in
    <em>Project Settings → XR Plug-in Management</em>.
  </li>
  <li>
    To update the controller configuration, navigate to
    <em>Project Settings → XR Plug-in Management → OpenXR</em> and replace the
    <strong>Valve Index Controller Profile</strong> with another (e.g., Meta Quest controllers)
    using the <code>+</code> / <code>−</code> icons.
  </li>
	  <li>
    The Tracking Origin Mode is set to Floor by default (assuming Base Stations). Inside-out tracking (i.e., Device) can be selected via the <em>Scene Hierarchy - Setup - XR Origin (XR Rig) Inspector</em>.
  </li>
  <li>
    The <strong>OpenXR Simulator</strong> can be enabled to use keyboard and mouse controls:
    <ul>
      <li>In the Hierarchy, enable <em>Setup → XR Device Simulator</em>.</li>
      <li>
        In the Game view, press the <code>+</code> on the simulator’s control window to view
        the input mappings.
      </li>
      <li>
        Navigation may feel unintuitive at first, but the on-screen guide helps clarify the
        control scheme.
      </li>
    </ul>
  </li>
</ol>

<h2>Development Team</h2>
<p>Development by Juriaan Wolfers (WUR), project managed by Caspar Krampe (WUR).</p>

<h2>License</h2>
<p>
  Copyright © 2026 Wageningen University &amp; Research.
</p>

<p>
  This project is licensed under the <strong>MIT License</strong>. You are free to use, modify, and distribute this software and documentation, provided that the original copyright notice and this permission notice are included in all copies or substantial portions of the software.
</p>

<p align="center">
  <a href="./LICENSE" target="_blank">View full license text</a>
</p>

<hr>

<h2>Citation</h2>
<p>
If you use this code in your research, please cite:<br><br>
 Krampe, C., Mehlhose, C., Wolfers, J., Van Loo, E. J., Hurst, W. (2026). Can Avatars Shape Sustainable Consumer Food Choices? Exploring Social Norms in Virtual Worlds?
</p>
