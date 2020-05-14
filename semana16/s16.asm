PA EQU 30h ; Entrada
PB EQU 31h ; Salida
CB EQU 33h ; Control del puerto B

EOI EQU 20h
IMR EQU 21h
INT0 EQU 24h
INT1 EQU 25h

ORG 2000H
mov al, 0FEh
out (IMR), al

in al, (PA)
mov al, 01h
out (INT0), al
mov al,55h
out (CB), al ; Configurar el puerto B como salida

L5:xor al, al
out (PB), al
mov al, 0AAh; 84h
out PB, al
jmp L5


ORG 7000h
INC cx
mov al, 20h
out (EOI), al
iret


ORG 0004h; Index del vector =  id (01) x 4
DIR dw 7000h ; vector de interupciones


END
