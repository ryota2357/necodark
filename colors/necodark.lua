-- Name:        necodark
-- Version:     0.1.3
-- Author:      ryota2357
-- License:     MIT
-- Repository:  https://github.com/ryota2357/necodark.git
-- Last change: 2023-09-04 Monday
vim.cmd [[
  set background=dark
  highlight clear
  if exists('syntax_on')
    syntax reset
  endif
  set t_Co=256
]]
vim.g.colors_name = 'necodark'
vim.api.nvim_set_hl(0, 'Comment', { fg = '#5c6370' })
vim.api.nvim_set_hl(0, 'Constant', { fg = '#edeef2', bg = '#1a1b1f', cterm = {} })
vim.api.nvim_set_hl(0, 'String', { fg = '#e88e73' })
vim.api.nvim_set_hl(0, 'Character', { fg = '#e88e73' })
vim.api.nvim_set_hl(0, 'Number', { fg = '#fb749c' })
vim.api.nvim_set_hl(0, 'Boolean', { fg = '#4dcbbb' })
vim.api.nvim_set_hl(0, 'Float', { fg = '#fb749c' })
vim.api.nvim_set_hl(0, 'Identifier', { fg = '#9fe7ff' })
vim.api.nvim_set_hl(0, 'Function', { fg = '#ffe8a3' })
vim.api.nvim_set_hl(0, 'Statement', { fg = '#8a99ff' })
vim.api.nvim_set_hl(0, 'Conditional', { fg = '#8a99ff' })
vim.api.nvim_set_hl(0, 'Repeat', { fg = '#8a99ff' })
vim.api.nvim_set_hl(0, 'Label', { fg = '#8a99ff' })
vim.api.nvim_set_hl(0, 'Operator', { fg = '#cdd3d6' })
vim.api.nvim_set_hl(0, 'Keyword', { fg = '#379df1' })
vim.api.nvim_set_hl(0, 'Exception', { fg = '#8a99ff' })
vim.api.nvim_set_hl(0, 'PreProc', { fg = '#379df1' })
vim.api.nvim_set_hl(0, 'Include', { fg = '#379df1' })
vim.api.nvim_set_hl(0, 'Define', { fg = '#379df1' })
vim.api.nvim_set_hl(0, 'Macro', { fg = '#379df1' })
vim.api.nvim_set_hl(0, 'PreCondit', { fg = '#379df1' })
vim.api.nvim_set_hl(0, 'Type', { fg = '#379df1' })
vim.api.nvim_set_hl(0, 'StorageClass', { fg = '#379df1' })
vim.api.nvim_set_hl(0, 'Structure', { fg = '#379df1' })
vim.api.nvim_set_hl(0, 'Typedef', { fg = '#379df1' })
vim.api.nvim_set_hl(0, 'Special', { fg = '#379df1' })
vim.api.nvim_set_hl(0, 'SpecialChar', { fg = '#e88e73' })
vim.api.nvim_set_hl(0, 'Tag', { fg = '#edeef2', bg = '#1a1b1f', cterm = {} })
vim.api.nvim_set_hl(0, 'Delimiter', { fg = '#edeef2', bg = '#1a1b1f', cterm = {} })
vim.api.nvim_set_hl(0, 'SpecialComment', { fg = '#5c6370' })
vim.api.nvim_set_hl(0, 'Debug', { fg = '#edeef2', bg = '#1a1b1f', cterm = {} })
vim.api.nvim_set_hl(0, 'Underlined', { fg = '#edeef2', bg = '#1a1b1f', underline = true, cterm = { underline = true } })
vim.api.nvim_set_hl(0, 'Error', { fg = '#ff3129', bg = 'NONE', cterm = {} })
vim.api.nvim_set_hl(0, 'Todo', { fg = '#fccd2c', bg = 'NONE', cterm = {} })
vim.api.nvim_set_hl(0, 'DiagnosticError', { fg = '#ff3129' })
vim.api.nvim_set_hl(0, 'DiagnosticWarn', { fg = '#fccd2c' })
vim.api.nvim_set_hl(0, 'DiagnosticInfo', { fg = '#14b5ff' })
vim.api.nvim_set_hl(0, 'DiagnosticHint', { fg = '#72b847' })
vim.api.nvim_set_hl(0, 'DiagnosticVirtualTextError', { fg = '#ff3129', bg = '#3c1e20', italic = true, cterm = { italic = true } })
vim.api.nvim_set_hl(0, 'DiagnosticVirtualTextWarn', { fg = '#fccd2c', bg = '#3c3621', italic = true, cterm = { italic = true } })
vim.api.nvim_set_hl(0, 'DiagnosticVirtualTextInfo', { fg = '#14b5ff', bg = '#193241', italic = true, cterm = { italic = true } })
vim.api.nvim_set_hl(0, 'DiagnosticVirtualTextHint', { fg = '#72b847', bg = '#273325', italic = true, cterm = { italic = true } })
vim.api.nvim_set_hl(0, 'DiagnosticUnderlineError', { sp = '#ff3129', undercurl = true, cterm = { undercurl = true } })
vim.api.nvim_set_hl(0, 'DiagnosticUnderlineWarn', { sp = '#fccd2c', undercurl = true, cterm = { undercurl = true } })
vim.api.nvim_set_hl(0, 'DiagnosticUnderlineInfo', { sp = '#14b5ff', undercurl = true, cterm = { undercurl = true } })
vim.api.nvim_set_hl(0, 'DiagnosticUnderlineHint', { sp = '#72b847', undercurl = true, cterm = { undercurl = true } })
vim.api.nvim_set_hl(0, 'GitSignsAdd', { fg = '#3db34d', cterm = {} })
vim.api.nvim_set_hl(0, 'GitSignsChange', { fg = '#d29922', cterm = {} })
vim.api.nvim_set_hl(0, 'GitSignsDelete', { fg = '#db403d', cterm = {} })
vim.api.nvim_set_hl(0, 'NotifyERRORBorder', { fg = '#8c2624', cterm = {} })
vim.api.nvim_set_hl(0, 'NotifyWARNBorder', { fg = '#806b25', cterm = {} })
vim.api.nvim_set_hl(0, 'NotifyINFOBorder', { fg = '#17688f', cterm = {} })
vim.api.nvim_set_hl(0, 'NotifyDEBUGBorder', { fg = '#555c68', cterm = {} })
vim.api.nvim_set_hl(0, 'NotifyTRACEBorder', { fg = '#525a8f', cterm = {} })
vim.api.nvim_set_hl(0, 'NotifyERRORIcon', { fg = '#ff3129', cterm = {} })
vim.api.nvim_set_hl(0, 'NotifyWARNIcon', { fg = '#fccd2c', cterm = {} })
vim.api.nvim_set_hl(0, 'NotifyINFOIcon', { fg = '#14b5ff', cterm = {} })
vim.api.nvim_set_hl(0, 'NotifyDEBUGIcon', { fg = '#5c6370', cterm = {} })
vim.api.nvim_set_hl(0, 'NotifyTRACEIcon', { fg = '#8a99ff', cterm = {} })
vim.api.nvim_set_hl(0, 'NotifyERRORTitle', { fg = '#ff3129' })
vim.api.nvim_set_hl(0, 'NotifyWARNTitle', { fg = '#fccd2c' })
vim.api.nvim_set_hl(0, 'NotifyINFOTitle', { fg = '#14b5ff' })
vim.api.nvim_set_hl(0, 'NotifyDEBUGTitle', { fg = '#5c6370' })
vim.api.nvim_set_hl(0, 'NotifyTRACETitle', { fg = '#8a99ff' })
vim.api.nvim_set_hl(0, 'IlluminatedWordText', { fg = 'NONE', bg = '#393c43' })
vim.api.nvim_set_hl(0, 'IlluminatedWordRead', { fg = 'NONE', bg = '#393c43' })
vim.api.nvim_set_hl(0, 'IlluminatedWordWrite', { fg = 'NONE', bg = '#393c43' })
vim.api.nvim_set_hl(0, 'FidgetTitle', { fg = '#1687bc', bg = 'NONE', bold = true, cterm = { bold = true } })
vim.api.nvim_set_hl(0, 'FidgetTask', { fg = '#5c6370', bg = 'NONE', cterm = {} })
vim.api.nvim_set_hl(0, 'diffAdded', { fg = '#3db34d', cterm = {} })
vim.api.nvim_set_hl(0, 'diffRemoved', { fg = '#db403d', cterm = {} })
vim.api.nvim_set_hl(0, 'diffChanged', { fg = '#d29922', cterm = {} })
vim.api.nvim_set_hl(0, 'diffOldFile', { fg = '#fccd2c', cterm = {} })
vim.api.nvim_set_hl(0, 'diffNewFile', { fg = '#72b847', cterm = {} })
vim.api.nvim_set_hl(0, 'diffFile', { fg = '#14b5ff', cterm = {} })
vim.api.nvim_set_hl(0, 'ColorColumn', { bg = '#39393f' })
vim.api.nvim_set_hl(0, 'Conceal', { fg = '#39393f', bg = 'NONE', cterm = {} })
vim.api.nvim_set_hl(0, 'CurSearch', { fg = '#1a1b1f', bg = '#4dcbbb' })
vim.api.nvim_set_hl(0, 'IncSearch', { link = 'CurSearch' })
vim.api.nvim_set_hl(0, 'Search', { fg = 'NONE', bg = '#334870', cterm = {} })
vim.api.nvim_set_hl(0, 'Cursor', { fg = '#1a1b1f', bg = '#edeef2' })
vim.api.nvim_set_hl(0, 'lCursor', { link = 'Cursor' })
vim.api.nvim_set_hl(0, 'CursorIM', { link = 'Cursor' })
vim.api.nvim_set_hl(0, 'CursorLine', { fg = 'NONE', bg = '#101115', cterm = {} })
vim.api.nvim_set_hl(0, 'CursorColumn', { link = 'CursorLine' })
vim.api.nvim_set_hl(0, 'Directory', { fg = '#9fe7ff' })
vim.api.nvim_set_hl(0, 'DiffAdd', { bg = '#213928' })
vim.api.nvim_set_hl(0, 'DiffChange', { bg = '#3f3420' })
vim.api.nvim_set_hl(0, 'DiffDelete', { bg = '#412225' })
vim.api.nvim_set_hl(0, 'DiffText', { bg = '#644d20' })
vim.api.nvim_set_hl(0, 'NonText', { fg = '#39393f', bg = 'NONE', cterm = {} })
vim.api.nvim_set_hl(0, 'EndOfBuffer', { link = 'NonText' })
vim.api.nvim_set_hl(0, 'ErrorMsg', { fg = '#ff3129', bg = 'NONE' })
vim.api.nvim_set_hl(0, 'WinSeparator', { fg = '#000000', bg = 'NONE' })
vim.api.nvim_set_hl(0, 'Folded', { fg = '#5c6370', bold = true, cterm = { bold = true } })
vim.api.nvim_set_hl(0, 'FoldColumn', { })
vim.api.nvim_set_hl(0, 'SignColumn', { fg = '#edeef2', bg = 'NONE' })
vim.api.nvim_set_hl(0, 'LineNr', { fg = '#5c6370' })
vim.api.nvim_set_hl(0, 'CursorLineNr', { fg = '#edeef2', bg = '#1a1b1f', cterm = {} })
vim.api.nvim_set_hl(0, 'MatchParen', { fg = 'NONE', bg = '#525760', cterm = {} })
vim.api.nvim_set_hl(0, 'ModeMsg', { fg = '#5c6370', italic = true, cterm = { italic = true } })
vim.api.nvim_set_hl(0, 'Normal', { fg = '#edeef2', bg = '#1a1b1f', cterm = {} })
vim.api.nvim_set_hl(0, 'MsgArea', { link = 'Normal' })
vim.api.nvim_set_hl(0, 'MoreMsg', { fg = '#5c6370', bold = true, cterm = { bold = true } })
vim.api.nvim_set_hl(0, 'NormalFloat', { fg = '#edeef2', bg = '#27292f', cterm = {} })
vim.api.nvim_set_hl(0, 'FloatBorder', { fg = '#a3a4a8', bg = 'NONE' })
vim.api.nvim_set_hl(0, 'NormalNC', { link = 'Normal' })
vim.api.nvim_set_hl(0, 'Pmenu', { fg = '#edeef2', bg = '#27292f', cterm = {} })
vim.api.nvim_set_hl(0, 'PmenuSel', { fg = 'NONE', bg = '#525760', cterm = {} })
vim.api.nvim_set_hl(0, 'SpecialKey', { fg = '#5c6370', bold = true, cterm = { bold = true } })
vim.api.nvim_set_hl(0, 'SpellBad', { sp = '#ff3129', undercurl = true, cterm = { undercurl = true } })
vim.api.nvim_set_hl(0, 'SpellCap', { sp = '#fccd2c', undercurl = true, cterm = { undercurl = true } })
vim.api.nvim_set_hl(0, 'SpellLocal', { sp = '#14b5ff', undercurl = true, cterm = { undercurl = true } })
vim.api.nvim_set_hl(0, 'SpellRare', { sp = '#14b5ff', undercurl = true, cterm = { undercurl = true } })
vim.api.nvim_set_hl(0, 'StatusLine', { fg = '#edeef2', bg = '#525760', cterm = {} })
vim.api.nvim_set_hl(0, 'StatusLineNC', { fg = '#edeef2', bg = '#1a1b1f', cterm = {} })
vim.api.nvim_set_hl(0, 'TabLine', { fg = '#5c6370' })
vim.api.nvim_set_hl(0, 'TabLineFill', { })
vim.api.nvim_set_hl(0, 'TabLineSel', { fg = '#edeef2', bg = '#1a1b1f', cterm = {} })
vim.api.nvim_set_hl(0, 'Title', { fg = '#e88e73', bold = true, cterm = { bold = true } })
vim.api.nvim_set_hl(0, 'Visual', { fg = 'NONE', bg = '#334870', cterm = {} })
vim.api.nvim_set_hl(0, 'VisualNOS', { link = 'Visual' })
vim.api.nvim_set_hl(0, 'WarningMsg', { fg = '#fccd2c', bg = 'NONE', cterm = {} })
vim.api.nvim_set_hl(0, 'Whitespace', { fg = '#39393f', bg = 'NONE', cterm = {} })
vim.api.nvim_set_hl(0, '@comment', { link = 'Comment' })
vim.api.nvim_set_hl(0, '@error', { link = 'Error' })
vim.api.nvim_set_hl(0, '@none', { fg = 'NONE', bg = 'NONE', sp = 'NONE', cterm = {} })
vim.api.nvim_set_hl(0, '@preproc', { link = 'PreProc' })
vim.api.nvim_set_hl(0, '@define', { link = 'Define' })
vim.api.nvim_set_hl(0, '@operator', { link = 'Operator' })
vim.api.nvim_set_hl(0, '@punctuation.delimiter', { fg = '#edeef2', bg = 'NONE' })
vim.api.nvim_set_hl(0, '@punctuation.bracket', { fg = '#edeef2', bg = 'NONE' })
vim.api.nvim_set_hl(0, '@punctuation.special', { fg = '#cdd3d6' })
vim.api.nvim_set_hl(0, '@string', { fg = '#e88e73' })
vim.api.nvim_set_hl(0, '@character', { fg = '#e88e73' })
vim.api.nvim_set_hl(0, '@boolean', { link = 'Boolean' })
vim.api.nvim_set_hl(0, '@number', { link = 'Number' })
vim.api.nvim_set_hl(0, '@float', { link = 'Float' })
vim.api.nvim_set_hl(0, '@function', { link = 'Function' })
vim.api.nvim_set_hl(0, '@function.builtin', { link = '@function' })
vim.api.nvim_set_hl(0, '@function.call', { link = '@function' })
vim.api.nvim_set_hl(0, '@function.macro', { link = '@function' })
vim.api.nvim_set_hl(0, '@method', { link = 'Function' })
vim.api.nvim_set_hl(0, '@method.call', { link = '@method' })
vim.api.nvim_set_hl(0, '@constructor', { fg = '#4bbe75' })
vim.api.nvim_set_hl(0, '@constructor.lua', { link = '@punctuation.bracket' })
vim.api.nvim_set_hl(0, '@parameter', { fg = '#9fe7ff' })
vim.api.nvim_set_hl(0, '@keyword', { link = 'Keyword' })
vim.api.nvim_set_hl(0, '@keyword.coroutine', { link = '@keyword' })
vim.api.nvim_set_hl(0, '@keyword.function', { link = '@keyword' })
vim.api.nvim_set_hl(0, '@keyword.operator', { fg = '#8a99ff' })
vim.api.nvim_set_hl(0, '@keyword.return', { link = '@keyword' })
vim.api.nvim_set_hl(0, '@conditional', { link = 'Conditional' })
vim.api.nvim_set_hl(0, '@conditional.ternary', { fg = '#8a99ff' })
vim.api.nvim_set_hl(0, '@repeat', { link = 'Repeat' })
vim.api.nvim_set_hl(0, '@debug', { link = 'Debug' })
vim.api.nvim_set_hl(0, '@label', { link = 'Label' })
vim.api.nvim_set_hl(0, '@include', { link = 'Include' })
vim.api.nvim_set_hl(0, '@exception', { link = 'Exception' })
vim.api.nvim_set_hl(0, '@type', { fg = '#4bbe75' })
vim.api.nvim_set_hl(0, '@type.builtin', { fg = '#379df1' })
vim.api.nvim_set_hl(0, '@type.qualifier', { link = '@type.builtin' })
vim.api.nvim_set_hl(0, '@storageclass', { link = '@type.builtin' })
vim.api.nvim_set_hl(0, '@attribute', { fg = '#ffe8a3' })
vim.api.nvim_set_hl(0, '@field', { fg = '#9fe7ff' })
vim.api.nvim_set_hl(0, '@property', { fg = '#9fe7ff' })
vim.api.nvim_set_hl(0, '@variable', { fg = '#9fe7ff' })
vim.api.nvim_set_hl(0, '@variable.builtin', { fg = '#379df1' })
vim.api.nvim_set_hl(0, '@constant', { fg = '#edeef2', bg = '#1a1b1f', cterm = {} })
vim.api.nvim_set_hl(0, '@constant.builtin', { fg = '#379df1' })
vim.api.nvim_set_hl(0, '@constant.macro', { fg = '#ffe8a3' })
vim.api.nvim_set_hl(0, '@namespace', { fg = '#edeef2', bg = '#1a1b1f', cterm = {} })
vim.api.nvim_set_hl(0, '@text', { fg = '#edeef2', bg = '#1a1b1f', cterm = {} })
vim.api.nvim_set_hl(0, '@text.strong', { fg = '#edeef2', bg = '#1a1b1f', bold = true, cterm = { bold = true } })
vim.api.nvim_set_hl(0, '@text.emphasis', { fg = '#edeef2', bg = '#1a1b1f', italic = true, cterm = { italic = true } })
vim.api.nvim_set_hl(0, '@text.underline', { link = 'Underlined' })
vim.api.nvim_set_hl(0, '@text.strike', { fg = '#edeef2', bg = '#1a1b1f', strikethrough = true, cterm = { strikethrough = true } })
vim.api.nvim_set_hl(0, '@text.title', { fg = '#e88e73', bold = true, cterm = { bold = true } })
vim.api.nvim_set_hl(0, '@text.todo', { fg = '#1a1b1f', bg = '#72b847' })
vim.api.nvim_set_hl(0, '@text.note', { fg = '#1a1b1f', bg = '#14b5ff' })
vim.api.nvim_set_hl(0, '@text.warning', { fg = '#1a1b1f', bg = '#fccd2c' })
vim.api.nvim_set_hl(0, '@text.danger', { fg = '#1a1b1f', bg = '#ff3129' })
vim.api.nvim_set_hl(0, '@text.diff.add', { fg = '#3db34d', cterm = {} })
vim.api.nvim_set_hl(0, '@text.diff.delete', { fg = '#db403d', cterm = {} })
vim.api.nvim_set_hl(0, '@tag', { fg = '#379df1' })
vim.api.nvim_set_hl(0, '@tag.delimiter', { fg = '#5c6370' })
vim.api.nvim_set_hl(0, '@lsp.type.class', { fg = '#4bbe75' })
vim.api.nvim_set_hl(0, '@lsp.type.type', { fg = '#4bbe75' })
vim.api.nvim_set_hl(0, '@lsp.type.struct', { fg = '#4bbe75' })
vim.api.nvim_set_hl(0, '@lsp.type.enum', { fg = '#4bbe75' })
vim.api.nvim_set_hl(0, '@lsp.type.namespace', { fg = '#edeef2', bg = '#1a1b1f', cterm = {} })
-- Built with Sccg 0.2.1