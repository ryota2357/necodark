" Name:        necodark
" Version:     0.1.2
" Author:      ryota2357
" License:     MIT
" Repository:  https://github.com/ryota2357/necodark.git
" Last change: 2023-06-01 Thursday
set background=dark
highlight clear
if exists('syntax_on')
  syntax reset
endif
set t_Co=256
let g:colors_name = 'necodark'
hi Comment guifg=#5c6370
hi Constant cterm=NONE guifg=#edeef2 guibg=#1a1b1f gui=NONE
hi String guifg=#e88e73
hi Character guifg=#e88e73
hi Number guifg=#fb749c
hi Boolean guifg=#4dcbbb
hi Float guifg=#fb749c
hi Identifier guifg=#9fe7ff
hi Function guifg=#ffe8a3
hi Statement guifg=#8a99ff
hi Conditional guifg=#8a99ff
hi Repeat guifg=#8a99ff
hi Label guifg=#8a99ff
hi Operator guifg=#cdd3d6
hi Keyword guifg=#379df1
hi Exception guifg=#8a99ff
hi PreProc guifg=#379df1
hi Include guifg=#379df1
hi Define guifg=#379df1
hi Macro guifg=#379df1
hi PreCondit guifg=#379df1
hi Type guifg=#379df1
hi StorageClass guifg=#379df1
hi Structure guifg=#379df1
hi Typedef guifg=#379df1
hi Special guifg=#379df1
hi SpecialChar guifg=#e88e73
hi Tag cterm=NONE guifg=#edeef2 guibg=#1a1b1f gui=NONE
hi Delimiter cterm=NONE guifg=#edeef2 guibg=#1a1b1f gui=NONE
hi SpecialComment guifg=#5c6370
hi Debug cterm=NONE guifg=#edeef2 guibg=#1a1b1f gui=NONE
hi Underlined cterm=underline guifg=#edeef2 guibg=#1a1b1f gui=underline
hi Error cterm=NONE guifg=#ff3129 guibg=NONE gui=NONE
hi Todo cterm=NONE guifg=#fccd2c guibg=NONE gui=NONE
hi GitSignsAdd cterm=NONE guifg=#3db34d gui=NONE
hi GitSignsChange cterm=NONE guifg=#d29922 gui=NONE
hi GitSignsDelete cterm=NONE guifg=#db403d gui=NONE
hi NotifyERRORBorder cterm=NONE guifg=#8c2624 gui=NONE
hi NotifyWARNBorder cterm=NONE guifg=#806b25 gui=NONE
hi NotifyINFOBorder cterm=NONE guifg=#17688f gui=NONE
hi NotifyDEBUGBorder cterm=NONE guifg=#555c68 gui=NONE
hi NotifyTRACEBorder cterm=NONE guifg=#525a8f gui=NONE
hi NotifyERRORIcon cterm=NONE guifg=#ff3129 gui=NONE
hi NotifyWARNIcon cterm=NONE guifg=#fccd2c gui=NONE
hi NotifyINFOIcon cterm=NONE guifg=#14b5ff gui=NONE
hi NotifyDEBUGIcon cterm=NONE guifg=#5c6370 gui=NONE
hi NotifyTRACEIcon cterm=NONE guifg=#8a99ff gui=NONE
hi NotifyERRORTitle guifg=#ff3129
hi NotifyWARNTitle guifg=#fccd2c
hi NotifyINFOTitle guifg=#14b5ff
hi NotifyDEBUGTitle guifg=#5c6370
hi NotifyTRACETitle guifg=#8a99ff
hi IlluminatedWordText guifg=NONE guibg=#393c43
hi IlluminatedWordRead guifg=NONE guibg=#393c43
hi IlluminatedWordWrite guifg=NONE guibg=#393c43
hi FidgetTitle cterm=bold guifg=#1687bc guibg=NONE gui=bold
hi FidgetTask cterm=NONE guifg=#5c6370 guibg=NONE gui=NONE
hi diffAdded cterm=NONE guifg=#3db34d gui=NONE
hi diffRemoved cterm=NONE guifg=#db403d gui=NONE
hi diffChanged cterm=NONE guifg=#d29922 gui=NONE
hi diffOldFile cterm=NONE guifg=#fccd2c gui=NONE
hi diffNewFile cterm=NONE guifg=#72b847 gui=NONE
hi diffFile cterm=NONE guifg=#14b5ff gui=NONE
hi ColorColumn guibg=#39393f
hi Conceal cterm=NONE guifg=#39393f guibg=NONE gui=NONE
hi Cursor guifg=#1a1b1f guibg=#edeef2
hi lCursor guifg=#1a1b1f guibg=#edeef2
hi CursorIM guifg=#1a1b1f guibg=#edeef2
hi CursorColumn cterm=NONE guifg=NONE guibg=#101115 gui=NONE
hi CursorLine cterm=NONE guifg=NONE guibg=#101115 gui=NONE
hi Directory guifg=#9fe7ff
hi DiffAdd guibg=#213928
hi DiffChange guibg=#3f3420
hi DiffDelete guibg=#412225
hi DiffText guibg=#644d20
hi EndOfBuffer cterm=NONE guifg=#39393f guibg=NONE gui=NONE
hi ErrorMsg guifg=#ff3129 guibg=NONE
hi Folded cterm=bold guifg=#5c6370 gui=bold
" hi FoldColumn
hi SignColumn guifg=#edeef2 guibg=NONE
hi IncSearch guifg=#1a1b1f guibg=#4dcbbb
hi LineNr guifg=#5c6370
" hi LineNrAbove
" hi LineNrBelow
hi CursorLineNr cterm=NONE guifg=#edeef2 guibg=#1a1b1f gui=NONE
" hi CursorLineFold
" hi CursorLineSign
hi MatchParen cterm=NONE guifg=NONE guibg=#525760 gui=NONE
hi ModeMsg cterm=italic guifg=#5c6370 gui=italic
hi MoreMsg cterm=bold guifg=#5c6370 gui=bold
hi NonText cterm=NONE guifg=#39393f guibg=NONE gui=NONE
hi Normal cterm=NONE guifg=#edeef2 guibg=#1a1b1f gui=NONE
hi Pmenu cterm=NONE guifg=#edeef2 guibg=#27292f gui=NONE
hi PmenuSel cterm=NONE guifg=NONE guibg=#525760 gui=NONE
" hi PmenuSbar
" hi PmenuThumb
" hi Question
" hi QuickFixLine
hi Search cterm=NONE guifg=NONE guibg=#334870 gui=NONE
hi CurSearch guifg=#1a1b1f guibg=#4dcbbb
hi SpecialKey cterm=NONE guifg=#39393f guibg=NONE gui=NONE
hi SpellBad cterm=undercurl guibg=NONE guisp=#ff3129 gui=undercurl
hi SpellCap cterm=undercurl guibg=NONE guisp=#fccd2c gui=undercurl
hi SpellLocal cterm=undercurl guibg=NONE guisp=#14b5ff gui=undercurl
hi SpellRare cterm=undercurl guibg=NONE guisp=#14b5ff gui=undercurl
hi StatusLine cterm=NONE guifg=#edeef2 guibg=#525760 gui=NONE
hi StatusLineNC cterm=NONE guifg=#edeef2 guibg=#1a1b1f gui=NONE
hi TabLine guifg=#5c6370
" hi TabLineFill
hi TabLineSel cterm=NONE guifg=#edeef2 guibg=#1a1b1f gui=NONE
hi Title cterm=bold guifg=#e88e73 gui=bold
hi Visual cterm=NONE guifg=NONE guibg=#334870 gui=NONE
hi VisualNOS cterm=NONE guifg=NONE guibg=#334870 gui=NONE
hi WarningMsg cterm=NONE guifg=#fccd2c guibg=NONE gui=NONE
" hi WildMenu
" hi Menu
" hi Scrollbar
" hi Tooltip
" Built with Sccg 0.2.1