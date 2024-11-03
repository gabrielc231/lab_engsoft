import { defineConfig } from 'vite'
import react from '@vitejs/plugin-react'
import path from 'path'

export default defineConfig({
// should be repository name
base: "",  
plugins: [react()],
  resolve: {
    alias: {
      '@': path.resolve(__dirname, 'src'), // Set `@` to point to `src`
    },
  },
})

