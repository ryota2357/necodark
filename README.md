# necodark

![Top-image](https://raw.githubusercontent.com/ryota2357/necodark/images/top.png)

## Installation

### vim

Please use `build/vim` branch.

<details>
<summary>example</summary>

dein.vim

```vim
call dein#add('ryota2357/necodark', #{ rev: 'build/vim' })
```

dein.vim (toml)

```toml
[[plugins]]
repo = 'ryota2357/necodark'
rev = 'build/vim'
```

vim-plug

```vim
Plug 'ryota2357/necodark', { 'branch': 'build/vim' }
```

</details>

### neovim

Please use `build/nvim` branch.

<details>
<summary>example</summary>
dein.vim

```vim
call dein#add('ryota2357/necodark', #{ rev: 'build/nvim' })
```

dein.vim (toml)

```toml
[[plugins]]
repo = 'ryota2357/necodark'
rev = 'build/nvim'
```

packer.nvim

```lua
use { 'ryota2357/necodark', branch = 'build/nvim' }
```

</details>
