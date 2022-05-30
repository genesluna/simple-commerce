import { AppBar, Toolbar, Typography } from "@mui/material";

function Header() {
  return (
    <AppBar position="static" sx={{ mb: 4 }}>
      <Toolbar>
        <Typography variant="h6">Simple Commerce</Typography>
      </Toolbar>
    </AppBar>
  );
}

export default Header;
