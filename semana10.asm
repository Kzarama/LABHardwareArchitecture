.386
.model flat, stdcall
option casemap : none
.data
IPHeader byte 45h, 00h,00h, 29h, 36h, 27h, 40h, 00h, 80h, 06h, 0d9h, 70h, 0c0h, 0a8h, 01h, 02h, 0dh, 58h, 1ch, 35h

.code
start:
    mov esi,0
    xor bx,bx
L11:mov ax,word ptr[IPHeader+esi]; AX : AH AL
    xchg al,ah 
    add esi,2
    add bx,ax
    cmp esi,20
    jne L11
    not bx
    
    xor eax, eax
    ret
    end start
    
%include "io.inc"

section .text
global CMAIN
CMAIN:
    ;write your code here
    xor eax, eax
    ret