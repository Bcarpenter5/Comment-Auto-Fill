let SessionLoad = 1
let s:so_save = &g:so | let s:siso_save = &g:siso | setg so=0 siso=0 | setl so=-1 siso=-1
let v:this_session=expand("<sfile>:p")
silent only
silent tabonly
cd ~/Documents/nait/svn/1221_bcarpenter5/cmpe1666
if expand('%') == '' && !&modified && line('$') <= 1 && getline(1) == ''
  let s:wipebuf = bufnr('%')
endif
let s:shortmess_save = &shortmess
if &shortmess =~ 'A'
  set shortmess=aoOA
else
  set shortmess=aoO
endif
badd +74 autoComenter/autoComenter/Form1.cs
badd +0 autoComenter/autoComenter/Program.cs
badd +33 autoComenter/autoComenter/Form1.Designer.cs
badd +1 /\$metadata\$/Project/autoComenter/Assembly/mscorlib/Symbol/System/String.cs
argglobal
%argdel
$argadd ~/Documents/nait/svn/1221_bcarpenter5/cmpe1666
edit autoComenter/autoComenter/Form1.Designer.cs
let s:save_splitbelow = &splitbelow
let s:save_splitright = &splitright
set splitbelow splitright
wincmd _ | wincmd |
split
1wincmd k
wincmd w
let &splitbelow = s:save_splitbelow
let &splitright = s:save_splitright
wincmd t
let s:save_winminheight = &winminheight
let s:save_winminwidth = &winminwidth
set winminheight=0
set winheight=1
set winminwidth=0
set winwidth=1
exe '1resize ' . ((&lines * 17 + 18) / 37)
exe '2resize ' . ((&lines * 17 + 18) / 37)
argglobal
setlocal fdm=manual
setlocal fde=0
setlocal fmr={{{,}}}
setlocal fdi=#
setlocal fdl=0
setlocal fml=1
setlocal fdn=20
setlocal fen
silent! normal! zE
let &fdl = &fdl
let s:l = 33 - ((8 * winheight(0) + 8) / 17)
if s:l < 1 | let s:l = 1 | endif
keepjumps exe s:l
normal! zt
keepjumps 33
normal! 0
lcd ~/Documents/nait/svn/1221_bcarpenter5/cmpe1666
wincmd w
argglobal
if bufexists(fnamemodify("~/Documents/nait/svn/1221_bcarpenter5/cmpe1666/autoComenter/autoComenter/Form1.cs", ":p")) | buffer ~/Documents/nait/svn/1221_bcarpenter5/cmpe1666/autoComenter/autoComenter/Form1.cs | else | edit ~/Documents/nait/svn/1221_bcarpenter5/cmpe1666/autoComenter/autoComenter/Form1.cs | endif
if &buftype ==# 'terminal'
  silent file ~/Documents/nait/svn/1221_bcarpenter5/cmpe1666/autoComenter/autoComenter/Form1.cs
endif
balt /\$metadata\$/Project/autoComenter/Assembly/mscorlib/Symbol/System/String.cs
setlocal fdm=manual
setlocal fde=0
setlocal fmr={{{,}}}
setlocal fdi=#
setlocal fdl=0
setlocal fml=1
setlocal fdn=20
setlocal fen
silent! normal! zE
let &fdl = &fdl
let s:l = 70 - ((8 * winheight(0) + 8) / 17)
if s:l < 1 | let s:l = 1 | endif
keepjumps exe s:l
normal! zt
keepjumps 70
normal! 021|
lcd ~/Documents/nait/svn/1221_bcarpenter5/cmpe1666
wincmd w
2wincmd w
exe '1resize ' . ((&lines * 17 + 18) / 37)
exe '2resize ' . ((&lines * 17 + 18) / 37)
tabnext 1
if exists('s:wipebuf') && len(win_findbuf(s:wipebuf)) == 0 && getbufvar(s:wipebuf, '&buftype') isnot# 'terminal'
  silent exe 'bwipe ' . s:wipebuf
endif
unlet! s:wipebuf
set winheight=1 winwidth=20
let &shortmess = s:shortmess_save
let &winminheight = s:save_winminheight
let &winminwidth = s:save_winminwidth
let s:sx = expand("<sfile>:p:r")."x.vim"
if filereadable(s:sx)
  exe "source " . fnameescape(s:sx)
endif
let &g:so = s:so_save | let &g:siso = s:siso_save
doautoall SessionLoadPost
unlet SessionLoad
" vim: set ft=vim :
