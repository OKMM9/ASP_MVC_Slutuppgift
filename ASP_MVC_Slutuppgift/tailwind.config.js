/** @type {import('tailwindcss').Config} */
module.exports = {
    content: [
        "./Views/**/*.cshtml",  // F�r Razor-sidor
        "./Pages/**/*.cshtml", // F�r Blazor eller Razor Pages
    ],
  theme: {
    extend: {},
  },
  plugins: [],
}

