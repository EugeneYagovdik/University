; LabWork #1 exe
; Write a program that can output 
; a string of characters to the screen   

    .model small
    .stack 100h  
    
    .data    
string db "Lab Work 1 exe by Pavel Syakachev",0Dh,0Ah,'$' 
 
    .code 
start:
    mov ax, @data
    mov ds, ax   
    mov ah, 9h
    mov dx, offset string
    int 21h           
    mov ax,4C00h
    int 21h  
    end start