.code

;(byte[] pixelsdouble, double redFactor, double greenFactor, double blueFactor, int y, int x, int stride);

MyProc1 PROC

	mov rcx, rcx			;RCX -> pixels[]
	movaps xmm0, xmm1		;xmm0 -> redFactor
 	movaps xmm1, xmm2		;xmm1 -> greenFactor
	movaps xmm2, xmm3		;xmm2 -> blueFactor
	xorps xmm3, xmm3
	mov r9, rsi				;r9 -> stride
	mov r10, [rsp + 40]		;r10 -> y
	mov r11, [rsp + 48]		;r11 -> x
	xor r12, r12
	
	
	mov r8, r10				;w r8 jest y
	imul r8, r9
	mov r12, r11
	imul r12, 4
	add r8, r12				;index w r8		
	xor r12, r12

	;ZAJETE REJESTRY RCX, XMM0-2, R8-11

	;KANAL NIEBIESKI MODYFIKACJA------------------------------------------------------------------------------

  
	movzx r12d, byte ptr [rcx + r8]				;w r9d wartoœæ blue 								
	cvtsi2sd xmm3, r12d							;rzutownaie originalPixels[index] w r12d i przenieœ do xmm3
	xor r12d, r12d								;zerowanie r12d
	mulpd xmm3, xmm2							;originalPixels[index] * blueFactor
	CVTTSD2SI r12d, xmm3						;w r12d newBlue

	cmp r12d, 0									;porownaj newBlue z 0
	jl LessThanZero								;skocz, jeœli newBlue < 0
	cmp r12d, 255								;porównaj newBlue z 255
	jg GreaterThan255							;skocz, jeœli newBlue > 255
	jmp Continue								;kontynuuj, jeœli newBlue jest w zakresie 0-255

LessThanZero:
	mov r12d, 0									;ustaw newBlue na 0				
	jmp Continue								

GreaterThan255:
	mov r12d, 255								;ustaw newBlue na 255
	
Continue:
	mov byte ptr [rcx + r8], r12b
	xor r12d, r12d
	xorps xmm3, xmm3

	;KANAL ZIELONY MODYFIKACJA-----------------------------------------------------------------------------------


	movzx r12d, byte ptr [rcx + r8 + 1]			 								
	cvtsi2sd xmm3, r12d							
	xor r12d, r12d								
	mulpd xmm3, xmm1							
	CVTTSD2SI r12d, xmm3						

	cmp r12d, 0									
	jl LessThanZeroGreen						
	cmp r12d, 255								
	jg GreaterThan255Green						
	jmp ContinueGreen							

LessThanZeroGreen:
	mov r12d, 0											
	jmp Continue								

GreaterThan255Green:
	mov r12d, 255								;ustaw newBlue na 255
	
ContinueGreen:
	mov byte ptr [rcx + r8 + 1], r12b
	xor r12d, r12d
	xorps xmm3, xmm3

	;KANAL CZERWONY MODYFIKACJA-----------------------------------------------------------------------------------

	movzx r12d, byte ptr [rcx + r8 + 2]										
	cvtsi2sd xmm3, r12d							
	xor r12d, r12d								
	mulpd xmm3, xmm0							
	CVTTSD2SI r12d, xmm3						

	cmp r12d, 0									
	jl LessThanZeroRed							
	cmp r12d, 255								
	jg GreaterThan255Red						
	jmp ContinueRed								

LessThanZeroRed:
	mov r12d, 0											
	jmp Continue								

GreaterThan255Red:
	mov r12d, 255								
	
ContinueRed:
	mov byte ptr [rcx + r8 + 2], r12b
	xor r12d, r12d
	xorps xmm3, xmm3

ret
MyProc1 ENDP
end