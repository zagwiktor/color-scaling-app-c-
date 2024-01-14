.code
AdjustColorsAsm proc
    push rbp
    mov rbp, rsp

    mov rax, rcx          ; wskaŸnik na tablicê bajtów obrazu
    mov rcx, rdx          ; liczba pikseli
    mov ebx, r8d          ; mno¿nik dla czerwonego (przeskalowany do 32-bitowej wartoœci)
    mov r8d, r9d          ; mno¿nik dla zielonego (przeskalowany do 32-bitowej wartoœci)
    mov r9d, [rbp+16]     ; mno¿nik dla niebieskiego (przeskalowany do 32-bitowej wartoœci)

pixel_loop:
    test rcx, rcx         ; sprawdŸ, czy pozosta³y jeszcze piksele do przetworzenia
    jz loop_end           ; jeœli nie, zakoñcz pêtlê

    ; Modyfikacja kana³u niebieskiego
    movzx r10d, byte ptr [rax]   ; wczytanie niebieskiego kana³u
    imul r10d, r9d               ; mno¿enie przez mno¿nik
    mov r11d, 100                ; sta³a reprezentuj¹ca 100%
    idiv r11d                    ; dzielenie przez 100
    cmp r10d, 0FFh               ; ograniczenie wartoœci do zakresu 0-255
    jle no_clamp_blue
    mov r10d, 0FFh

no_clamp_blue:
    mov [rax], r10b              ; zapisanie zmodyfikowanego kana³u niebieskiego

    ; Modyfikacja kana³u zielonego
    movzx r10d, byte ptr [rax+1] ; wczytanie zielonego kana³u
    imul r10d, r8d               ; mno¿enie przez mno¿nik
    idiv r11d                    ; dzielenie przez 100
    cmp r10d, 0FFh               ; ograniczenie wartoœci do zakresu 0-255
    jle no_clamp_green
    mov r10d, 0FFh

no_clamp_green:
    mov [rax+1], r10b            ; zapisanie zmodyfikowanego kana³u zielonego

    ; Modyfikacja kana³u czerwonego
    movzx r10d, byte ptr [rax+2] ; wczytanie czerwonego kana³u
    imul r10d, ebx               ; mno¿enie przez mno¿nik
    idiv r11d                    ; dzielenie przez 100
    cmp r10d, 0FFh               ; ograniczenie wartoœci do zakresu 0-255
    jle no_clamp_red
    mov r10d, 0FFh

no_clamp_red:
    mov [rax+2], r10b ; zapisanie zmodyfikowanego kana³u czerwonego

    ; Przejœcie do nastêpnego piksela
    add rax, 4
    dec rcx
    jmp pixel_loop

loop_end:
mov rsp, rbp
pop rbp
ret

AdjustColorsAsm endp
end