#version 140

// post_copy.fs

#ifdef GL_ES
precision mediump float;
#endif

uniform sampler2D PostSourceTexture;

in vec2 v_TexCoord;
in vec4 v_Color;

out vec4 out_FragColor;

void main() 
{
  vec4 texel = texture(PostSourceTexture, v_TexCoord);

  out_FragColor.x = pow(texel.x, 0.4545);
  out_FragColor.y = pow(texel.y, 0.4545);
  out_FragColor.z = pow(texel.z, 0.4545);
  out_FragColor.w = texel.w;
}
