.code
AdjustColorsAsm proc
    push rbp
    mov rbp, rsp

    mov rax, rcx          ; wska�nik na tablic� bajt�w obrazu
    mov rcx, rdx          ; liczba pikseli
    mov ebx, r8d          ; mno�nik dla czerwonego (przeskalowany do 32-bitowej warto�ci)
    mov r8d, r9d          ; mno�nik dla zielonego (przeskalowany do 32-bitowej warto�ci)
    mov r9d, [rbp+16]     ; mno�nik dla niebieskiego (przeskalowany do 32-bitowej warto�ci)

pixel_loop:
    test rcx, rcx         ; sprawd�, czy pozosta�y jeszcze piksele do przetworzenia
    jz loop_end           ; je�li nie, zako�cz p�tl�

    ; Modyfikacja kana�u niebieskiego
    movzx r10d, byte ptr [rax]   ; wczytanie niebieskiego kana�u
    imul r10d, r9d               ; mno�enie przez mno�nik
    mov r11d, 100                ; sta�a reprezentuj�ca 100%
    idiv r11d                    ; dzielenie przez 100
    cmp r10d, 0FFh               ; ograniczenie warto�ci do zakresu 0-255
    jle no_clamp_blue
    mov r10d, 0FFh

no_clamp_blue:
    mov [rax], r10b              ; zapisanie zmodyfikowanego kana�u niebieskiego

    ; Modyfikacja kana�u zielonego
    movzx r10d, byte ptr [rax+1] ; wczytanie zielonego kana�u
    imul r10d, r8d               ; mno�enie przez mno�nik
    idiv r11d                    ; dzielenie przez 100
    cmp r10d, 0FFh               ; ograniczenie warto�ci do zakresu 0-255
    jle no_clamp_green
    mov r10d, 0FFh

no_clamp_green:
    mov [rax+1], r10b            ; zapisanie zmodyfikowanego kana�u zielonego

    ; Modyfikacja kana�u czerwonego
    movzx r10d, byte ptr [rax+2] ; wczytanie czerwonego kana�u
    imul r10d, ebx               ; mno�enie przez mno�nik
    idiv r11d                    ; dzielenie przez 100
    cmp r10d, 0FFh               ; ograniczenie warto�ci do zakresu 0-255
    jle no_clamp_red
    mov r10d, 0FFh

no_clamp_red:
    mov [rax+2], r10b ; zapisanie zmodyfikowanego kana�u czerwonego

    ; Przej�cie do nast�pnego piksela
    add rax, 4
    dec rcx
    jmp pixel_loop

loop_end:
mov rsp, rbp
pop rbp
ret

AdjustColorsAsm endp
end