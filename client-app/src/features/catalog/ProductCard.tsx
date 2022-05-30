import {
  Card,
  CardMedia,
  CardContent,
  Typography,
  CardActions,
  Button,
} from "@mui/material";
import { Product } from "../../app/models/product";

interface Props {
  product: Product;
}

function ProductCard({ product }: Props) {
  return (
    <Card sx={{ maxWidth: 300, height: "100%" }}>
      <CardMedia
        component="img"
        image={product.pictureUrl}
        title={product.name}
        alt={product.name}
      />

      <CardContent>
        <Typography gutterBottom variant="h5">
          ${(product.price / 100).toFixed(2)}
        </Typography>
        <Typography variant="subtitle1">{product.name}</Typography>
      </CardContent>
      <CardActions>
        <Button size="small">ADD TO CART</Button>
        <Button size="small">DETAILS</Button>
      </CardActions>
    </Card>
  );
}

export default ProductCard;
