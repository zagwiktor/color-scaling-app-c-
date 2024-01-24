.code

AdjustColorsAsm PROC

	mov rcx, rcx				;RCX -> pixels[]
	movaps xmm0, xmm1			;xmm0 -> redFactor
 	movaps xmm1, xmm2			;xmm1 -> greenFactor
	movaps xmm2, xmm3			;xmm2 -> blueFactor
	xorps xmm3, xmm3			;zerowanie xmm3
	mov r9, rsi					;r9 -> stride
	mov r10, [rsp + 40]			;r10 -> y
	mov r11, [rsp + 48]			;r11 -> x
	xor r12, r12				;zerowanie r12
	
	
	mov r8, r10					;w r8 jest y
	imul r8, r9					;y * stride
	mov r12, r11				;w r12 jest x
	imul r12, 4					;x * 4
	add r8, r12					;index w r8, który jest potrzebny do operacji na konkretnych pixealach	
	xor r12, r12				;zerwoanie 


	;KANAL NIEBIESKI MODYFIKACJA------------------------------------------------------------------------------

	movzx r12d, byte ptr [rcx + r8]				;w r12d wartoœæ blue 								
	cvtsi2ss xmm3, r12d							;rzutownaie pixel[index] w r12d i przenieœ do xmm3
	xor r12d, r12d								;zerowanie r12d
	vmulps xmm3, xmm3, xmm2 					;pixel[index] * blueFactor
	cvtss2si r12d, xmm3							;w r12d newBlue

	cmp r12d, 0									;porownaj newBlue z 0
	jl LessThanZero								;skocz, jeœli newBlue < 0
	cmp r12d, 255								;porównaj newBlue z 255
	jg GreaterThan255							;skocz, jeœli newBlue > 255
	jmp Continue								;skok do etykiety odpowiedzialnej za wpisanie newBlue 

LessThanZero:
	mov r12d, 0									;ustaw newBlue na 0				
	jmp Continue								

GreaterThan255:
	mov r12d, 255								;ustaw newBlue na 255
	
Continue:
	mov byte ptr [rcx + r8], r12b				;pixel[index] = newBlue
	xor r12d, r12d
	xorps xmm3, xmm3

	;KANAL ZIELONY MODYFIKACJA----------------------------------------------------------------------------------

	movzx r12d, byte ptr [rcx + r8 + 1]			;w r12d wartoœæ green								
	cvtsi2ss xmm3, r12d							;rzutownaie pixel[index] w r12d i przenieœ do xmm3
	xor r12d, r12d								;zerowanie r12d
	vmulps xmm3, xmm3, xmm1						;pixel[index] * greenFactor
	cvtss2si r12d, xmm3							;w r12d newGreen

	cmp r12d, 0									;porownaj newGreen z 0
	jl LessThanZeroGreen						;skocz, jeœli newGreen < 0
	cmp r12d, 255								;porównaj newGreen z 255
	jg GreaterThan255Green						;skocz, jeœli newGreen > 255
	jmp ContinueGreen							;skok do etykiety odpowiedzialnej za wpisanie newGreen

LessThanZeroGreen:								;ustaw newGreen na 0	
	mov r12d, 0											
	jmp Continue								

GreaterThan255Green:							;ustaw newGreen na 255
	mov r12d, 255								
	
ContinueGreen:
	mov byte ptr [rcx + r8 + 1], r12b			;pixel[index] = newGreen
	xor r12d, r12d
	xorps xmm3, xmm3

	;KANAL CZERWONY MODYFIKACJA----------------------------------------------------------------------------------

	movzx r12d, byte ptr [rcx + r8 + 2]			;w r12d wartoœæ red								
	cvtsi2ss xmm3, r12d							;rzutownaie pixel[index] w r12d i przenieœ do xmm3
	xor r12d, r12d								;zerowanie r12d
	vmulps xmm3, xmm3, xmm0						;pixel[index] * redFactor
	cvtss2si r12d, xmm3							;w r12d newRed

	cmp r12d, 0									;porownaj newRed z 0
	jl LessThanZeroRed							;skocz, jeœli newRed < 0
	cmp r12d, 255								;porównaj newRed z 255
	jg GreaterThan255Red						;skocz, jeœli newRed > 255
	jmp ContinueRed								;skok do etykiety odpowiedzialnej za wpisanie newRed

LessThanZeroRed:								;ustaw newRed na 0
	mov r12d, 0											
	jmp Continue								

GreaterThan255Red:								;ustaw newRed na 255
	mov r12d, 255								
	
ContinueRed:
	mov byte ptr [rcx + r8 + 2], r12b			;pixel[index] = newRed
	xor r12d, r12d
	xorps xmm3, xmm3

ret
AdjustColorsAsm ENDP
end