-- Made using: GMOD Addon Template Creator
-- Script from: https://wiki.facepunch.com/gmod/Derma_Basic_Guide#code

local Frame = vgui.Create( "DFrame" )
Frame:SetPos( 5, 5 ) 
Frame:SetSize( 300, 150 ) 
Frame:SetTitle( "Name window" ) 
Frame:SetVisible( true ) 
Frame:SetDraggable( false ) 
Frame:ShowCloseButton( true ) 
Frame:MakePopup()