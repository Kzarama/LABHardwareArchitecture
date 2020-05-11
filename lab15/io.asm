PA EQU 30h ; ENTRADA
PB EQU 31h ; SALIDA
CB EQU 33h 

ORG 2000H
in al, (PA)
;cb = 11111111

xor al,al
out (CB), al

l5: mov al, 0aah
out (PB), al
mov al, 55h
out (PB), al
jmp l5
END
