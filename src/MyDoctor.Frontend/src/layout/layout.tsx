import * as React from "react";
import Box from "@mui/material/Box";

export default function Layout({ children }: React.PropsWithChildren) {
  return <Box component="main">{children}</Box>;
}
