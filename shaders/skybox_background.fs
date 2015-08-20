#version 140

// skybox_background.fs

#ifdef GL_ES
precision mediump float;
#endif

uniform samplerCube SkyboxTexture;
uniform vec4 Color;

in vec3 v_SkyboxDir;

out vec4 out_FragColor;

void main() 
{
    vec4 texel = texture(SkyboxTexture, v_SkyboxDir);
    out_FragColor = vec4(pow(mix(texel.xyz, Color.xyz, Color.w), vec3(2.0, 2.0, 2.0)), 0.01);
}
